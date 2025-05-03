using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {

        if ((DataSource.Products.FirstOrDefault(i => i.ProductId == item.ProductId)) != null)
            throw new DalAlreadyExistsIdException("this product already exists.");
        DataSource.Products.Add(item);
        string message = "Create Product Object.";
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        return item.ProductId;

    }

    public Product? Read(int id)
    {
        Product c = DataSource.Products.FirstOrDefault(i => i.ProductId == id);

        if (c != null)
        {
            string message = "Read Customer Object.";
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

            return c;
        }
        throw new DalNotExistsIdException("this Product isn't exists.");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        Product c = DataSource.Products.FirstOrDefault(i => filter(i));

        if (c != null)
        {
            return c;
            string message = "Read a Product Object.";
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
        }
      
        throw new DalNotExistsIdException("this product isn't exists.");
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        string message = "ReadAll Products Object.";
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return DataSource.Products;

        return DataSource.Products.Where(i => filter(i)).ToList();

    }

    public void Update(Product item)
    {
        Product c = DataSource.Products.FirstOrDefault(i => i.ProductId == item.ProductId);

        if (c != null)
        {
            Delete(c.ProductId);
            Create(item);
            string message = "Update a Product Object.";
            Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

            return;
        }

        throw new DalNotExistsIdException("this Product isn't exists.");

    }

    public void Delete(int id)
    {
        Product c = DataSource.Products.FirstOrDefault(i => i.ProductId == id);
        {
            if (c != null)
            {
                DataSource.Products.Remove(c);
                string message = "Delete a Product Object.";
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this Product isn't exists.");
    }
}
