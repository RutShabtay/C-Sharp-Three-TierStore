
namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {

        if ((DataSource.Customers.FirstOrDefault(i => i.customerId == item.customerId)) != null)
            throw new DalAlreadyExistsIdException("this customer already exists.");
        DataSource.Customers.Add(item);
        string message = "Create Customer Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
        return item.customerId;

    }

    public Customer? Read(int id)
    {
        Customer c = DataSource.Customers.FirstOrDefault(i => i.customerId == id);

        if (c != null)
        {
            string message = "Read Customer Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;
        }

        throw new DalNotExistsIdException("this customer isn't exists.");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        Customer c = DataSource.Customers.FirstOrDefault(i => filter(i));

        if (c != null)
        {
            string message = "Read Customer Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;
        }
        throw new DalNotExistsIdException("this customer isn't exists.");
    }


    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        string message = "ReadAll Customer Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return DataSource.Customers;

        return DataSource.Customers.Where(i => filter(i)).ToList();

    }

    public void Update(Customer item)
    {
        Customer c = DataSource.Customers.FirstOrDefault(i => i.customerId == item.customerId);

        if (c != null)
        {
            Delete(c.customerId);
            Create(item);
            string message = "Update a Customer Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return;
        }

        throw new DalNotExistsIdException("this customer isn't exists.");

    }

    public void Delete(int id)
    {
        Customer c = DataSource.Customers.FirstOrDefault(i => i.customerId == id);
        {
            if (c != null)
            {
                DataSource.Customers.Remove(c);
                string message = "Delete Customer Object.";
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this customer isn't exists.");

    }

}





