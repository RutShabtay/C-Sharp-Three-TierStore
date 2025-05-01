namespace Dal;
using DalApi;
using DO;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;


internal class CustomerImplementation : ICustomer
{
    static object lockObject = new object();

    public List<Customer> Deserialize()
    {
        try
        {
            List<Customer>? customerList;
            XmlSerializer serializerList = new XmlSerializer(typeof(List<Customer>));
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Open, FileAccess.Read))
                {
                    customerList = serializerList.Deserialize(fs) as List<Customer>;
                }
            }
                if (customerList == null)
                {
                    customerList = new List<Customer>();
                }
                return customerList;
            
        }
        catch (Exception ex)
        {
            throw new DalReadForXmlException("Customer " + ex.Message);
        }
    }


    private void Serialize(List<Customer> customerList)
    {
        try
        {
            lock (lockObject)
            {
                using (FileStream fs = new FileStream("../xml/customers.xml", FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer serializerList = new XmlSerializer(typeof(List<Customer>));
                    serializerList.Serialize(fs, customerList);
                }
            }
        }
        catch(Exception ex)
        {
            throw new DalWriteForXmlException("Customer "+ex.Message);
        }

    }

    public int Create(Customer item)
    {
        List<Customer> customerList = Deserialize();

        if ((customerList.FirstOrDefault(i => i.customerId == item.customerId)) != null)
            throw new DalAlreadyExistsIdException("this customer already exists.");
        customerList.Add(item);
        Serialize(customerList);
        string message = "Create Customer Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
        return item.customerId;

    }

    public Customer? Read(int id)
    {
        List<Customer> customerList = Deserialize();
        Customer? c = customerList.FirstOrDefault(i => i.customerId == id);

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
        List<Customer> customerList = Deserialize();
        Customer? c = customerList.FirstOrDefault(i => filter(i));

        if (c != null)
        {
            string message = "Read Customer Object.";
            Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);
            return c;
        }
        throw new DalNotExistsIdException("this customer isn't exists.");
    }


    public List<Customer>? ReadAll(Func<Customer, bool>? filter = null)
    {
        List<Customer> customerList = Deserialize();

        string message = "ReadAll Customer Object.";
        Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

        if (filter == null)
            return customerList;

        return customerList?.Where(i => filter(i)).ToList();

    }

    public void Update(Customer item)
    {

        Customer c = Deserialize().FirstOrDefault(i => i.customerId == item.customerId);

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
        List<Customer> customerList = Deserialize();

        Customer c = customerList.FirstOrDefault(i => i.customerId == id);
        {
            if (c != null)
            {
                customerList.Remove(c);
                Serialize(customerList);
                string message = "Delete Customer Object.";
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, message);

                return;
            }
        }
        throw new DalNotExistsIdException("this customer isn't exists.");

    }
}
