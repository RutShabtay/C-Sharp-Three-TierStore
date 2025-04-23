
using DO;
using DalApi;
using System.Reflection;
namespace Dal;


internal class SaleImplementation:ISale
{
    public int Create(Sale item)
    {

        if ((DataSource.Sales.FirstOrDefault(i => i.saleId == item.saleId)) != null)
            throw new DalAlreadyExistsIdException("this Sale already exists.");
        DataSource.Sales.Add(item);
        string message = "Create a Sale Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        return item.saleId;

    }

    public Sale? Read(int id)
    {
        Sale c = DataSource.Sales.FirstOrDefault(i => i.saleId == id);

        if (c != null)
        {
            string message = "Read a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;
        }
        throw new DalNotExistsIdException("this Sale isn't exists.");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale c = DataSource.Sales.FirstOrDefault(i => filter(i));

        if (c != null)
        {
            string message = "Read a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;

        }
        throw new DalNotExistsIdException("this sale isn't exists.");
    }


    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        string message = "ReadAll sale Objects.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return DataSource.Sales;

        return DataSource.Sales.Where(i => filter(i)).ToList();

    }

    public void Update(Sale item)
    {
        Sale c = DataSource.Sales.FirstOrDefault(i => i.saleId == item.saleId);

        if (c != null)
        {
            Delete(c.saleId);
            Create(item);
            string message = "Update a Sale Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return;
        }

        throw new DalNotExistsIdException("this Sale isn't exists.");

    }

    public void Delete(int id)
    {
        Sale c = DataSource.Sales.FirstOrDefault(i => i.saleId == id);
        {
            if (c != null)
            {
                DataSource.Sales.Remove(c);
                string message = "Delete a Sale Object.";
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this Sale isn't exists.");
    }

}
