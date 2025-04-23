using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class CustomerImplementation : BlApi.ICustomer
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            return _dal.Customer.Create(item.CustomerToDo());
        }
        public BO.Customer? Read(int id)
        {
            return _dal.Customer.Read(id)?.CustomerToBo();
        }
        public BO.Customer? Read(Func<DO.Customer, bool> filter)
        {
            return _dal.Customer.Read(filter)?.CustomerToBo();
        }
        public List<BO.Customer> ReadAll(Func<DO.Customer, bool>? filter = null)
        {
            return _dal.Customer.ReadAll(filter)?.Select(q => q.CustomerToBo()).ToList() ?? new List<BO.Customer>();

        }
        public void Update(BO.Customer item)
        {
            _dal.Customer.Update(item.CustomerToDo());
        }

        public void Delete(int id)
        {
            _dal.Customer.Delete(id);
        }
        public bool isExists(int customerId)
        {
            DO.Customer? customer = _dal.Customer.Read(customerId);
            if (customer != null)
                return true;
            return false;
        }

    }
}
