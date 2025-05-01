using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal;


internal class SaleImplementation : ISale
{
    private const string FILE_PATH = "../xml/sales.xml";
    private const string ID_SALE = "SaleId";
    private const string ID_SALE_P = "SaleProductId";
    private const string MIN_AMOUNT_SALE = "RequiredQuantityForDiscount";
    private const string FAINAL_PRICE = "FinalPrice";
    private const string IS_ONLY_CLUB = "IsIntendedForAllCustomers";
    private const string START_SALE_DATE = "SaleStartDate";
    private const string LAST_SALE_DATE = "SaleEndDate";
    private const string CLASS = "Sale";


    private List<Sale> Deserialize()
    {
        if (!File.Exists(FILE_PATH))
            return new List<Sale>();

        XElement root = XElement.Load(FILE_PATH);

        return (from sale in root.Elements("Sale")
                select new Sale
                {
                    SaleId = int.TryParse(sale.Element(ID_SALE)?.Value, out int saleId) ? saleId : 0,
                    SaleProductId = int.TryParse(sale.Element(ID_SALE_P)?.Value, out int saleProductId) ? saleProductId : 0,
                    RequiredQuantityForDiscount = int.TryParse(sale.Element(MIN_AMOUNT_SALE)?.Value, out int requiredQty) ? (int?)requiredQty : null,
                    FinalPrice = double.TryParse(sale.Element(FAINAL_PRICE)?.Value, out double finalPrice) ? finalPrice : 0.0,
                    IsIntendedForAllCustomers = bool.TryParse(sale.Element(IS_ONLY_CLUB)?.Value, out bool isForAll) && isForAll,
                    SaleStartDate = DateTime.TryParse(sale.Element(START_SALE_DATE)?.Value, out DateTime startDate) ? startDate : DateTime.MinValue,
                    SaleEndDate = DateTime.TryParse(sale.Element(LAST_SALE_DATE)?.Value, out DateTime endDate) ? (DateTime?)endDate : null
                }).ToList();
    }


    private void Serialize(List<Sale> sales)
    {
        XElement root = new XElement(CLASS,
            from sale in sales
            select new XElement("Sale",
                new XElement(ID_SALE, sale.SaleId),
                new XElement(ID_SALE_P, sale.SaleProductId),
                new XElement(MIN_AMOUNT_SALE, sale.RequiredQuantityForDiscount),
                new XElement(FAINAL_PRICE, sale.FinalPrice),
                new XElement(IS_ONLY_CLUB, sale.IsIntendedForAllCustomers),
                new XElement(START_SALE_DATE, sale.SaleStartDate),
                new XElement(LAST_SALE_DATE, sale.SaleEndDate)
            )
        );

        root.Save(FILE_PATH);
    }

    public int Create(Sale item)
    {

        List<Sale> saleList = Deserialize();
        if (item.SaleId == 0)
        {
            item = item with { SaleId = Config.codeSale };
        }
        if ((saleList.FirstOrDefault(i => i.SaleId == item.SaleId)) != null)
            throw new DalAlreadyExistsIdException("this Sale already exists.");

        saleList.Add(item);
        Serialize(saleList);
        string message = "Create a Sale Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        return item.SaleId;

    }

    public Sale? Read(int id)
    {
        Sale? s = Deserialize().FirstOrDefault(i => i.SaleId == id);

        if (s != null)
        {
            string message = "Read a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return s;
        }
        throw new DalNotExistsIdException("this Sale isn't exists.");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale? c = Deserialize().FirstOrDefault(i => filter(i));

        if (c != null)
        {
            string message = "Read a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;

        }
        throw new DalNotExistsIdException("this sale isn't exists.");
    }


    public List<Sale>? ReadAll(Func<Sale, bool>? filter = null)
    {
        List<Sale>? saleList = Deserialize();

        string message = "ReadAll sale Objects.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return saleList;

        return saleList.Where(i => filter(i)).ToList();

    }

    public void Update(Sale item)
    {
        Sale? c = Deserialize().FirstOrDefault(i => i.SaleId == item.SaleId);

        if (c != null)
        {
            Delete(c.SaleId);
            Create(item);
            string message = "Update a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return;
        }

        throw new DalNotExistsIdException("this Sale isn't exists.");

    }

    public void Delete(int id)
    {
        List<Sale> saleList = Deserialize();

        Sale? s = saleList.FirstOrDefault(i => i.SaleId == id);
        {
            if (s != null)
            {
                saleList.Remove(s);
                string message = "Delete a Sale Object.";
                Serialize(saleList);
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this Sale isn't exists.");
    }

}
