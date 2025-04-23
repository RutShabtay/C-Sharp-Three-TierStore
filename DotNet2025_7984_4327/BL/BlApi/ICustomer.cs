using BO;

namespace BlApi
{
    public interface ICustomer
    {
        int Create(BO.Customer item);
        BO.Customer? Read(int id);
        BO.Customer? Read(Func<DO.Customer, bool> filter);
        List<BO.Customer> ReadAll(Func<DO.Customer, bool>? filter = null);
        void Update(BO.Customer item);
        void Delete(int id);
        bool isExists(int customerId);
    }
}
