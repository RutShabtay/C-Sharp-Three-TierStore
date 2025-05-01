using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    static object lockObject = new object();

    public List<Product> Deserialize()
    {
        try
        {
            List<Product>? productList;
            XmlSerializer serializerList = new XmlSerializer(typeof(List<Product>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Open, FileAccess.Read))
                {
                    productList = serializerList.Deserialize(fs) as List<Product>;
                }
            }
            if (productList == null)
            {
                productList = new List<Product>();
            }
            return productList;

        }
        catch (Exception ex)
        {
            throw new DalReadForXmlException("Product " + ex.Message);
        }
    }


    private void Serialize(List<Product> productList)
    {
        try
        {
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/products.xml", FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer serializerList = new XmlSerializer(typeof(List<Product>));
                    serializerList.Serialize(fs, productList);
                }
            }
        }
        catch (Exception ex)
        {
            throw new DalWriteForXmlException("Product " + ex.Message);
        }

    }
    public int Create(Product item)
    {
        List<Product> productList = Deserialize();
        Product p = item with { productId = Config.codeProduct };
        if ((productList.FirstOrDefault(i => i.productId == item.productId)) != null)
            throw new DalAlreadyExistsIdException("this product already exists.");
        productList.Add(p);
        Serialize(productList);
        string message = "Create Product Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
        return item.productId;
    }

    public Product? Read(int id)
    {

        Product c = Deserialize().FirstOrDefault(i => i.productId == id);

        if (c != null)
        {
            string message = "Read Customer Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;
        }
        throw new DalNotExistsIdException("this Product isn't exists.");
    }

    public Product? Read(Func<Product, bool> filter)
    {

        Product? p = Deserialize().FirstOrDefault(i => filter(i));

        if (p != null)
        {
            string message = "Read a Product Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return p;
        }

        throw new DalNotExistsIdException("this product isn't exists.");
    }

    public List<Product>? ReadAll(Func<Product, bool>? filter = null)
    {
        List<Product> productList = Deserialize();

        string message = "ReadAll Products Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return productList;

        return productList.Where(i => filter(i)).ToList();

    }

    public void Update(Product item)
    {

        Product? c = Deserialize().FirstOrDefault(i => i.productId == item.productId);

        if (c != null)
        {
            Delete(c.productId);
            Create(item);
            string message = "Update a Product Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

            return;
        }

        throw new DalNotExistsIdException("this Product isn't exists.");

    }

    public void Delete(int id)
    {
        List<Product> productList = Deserialize();

        Product? p = productList.FirstOrDefault(i => i.productId == id);
        {
            if (p != null)
            {
                productList.Remove(p);
                Serialize(productList);
                string message = "Delete a Product Object.";
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this Product isn't exists.");

    }
}
