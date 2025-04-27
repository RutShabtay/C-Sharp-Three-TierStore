using BlApi;
using BO;
using DalApi;
using DO;
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
            try
            {
                return _dal.Customer.Create(item.CustomerToDo());
            }
            catch (Exception ex)
            {
                throw new BO.BlAlreadyExistsIdException("", ex);
            }
        }
        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id)?.CustomerToBo();
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }
        }
        public BO.Customer? Read(Func<DO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(filter)?.CustomerToBo();
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }
        }
        public List<BO.Customer> ReadAll(Func<DO.Customer, bool>? filter = null)
        {
            try
            {
                return _dal.Customer.ReadAll(filter)?.Select(q => q.CustomerToBo()).ToList() ?? new List<BO.Customer>();
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occured in func ReadAll " + ex.Message);
            }

        }
        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.CustomerToDo());
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }
        }
        public bool IsExists(int customerId)
        {
            DO.Customer? customer;
            try
            {
                customer = _dal.Customer.Read(customerId);
                Console.WriteLine(customer);
            }
            catch (DalNotExistsIdException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException(ex.Message);
            }
            if (customer != null)
                return true;
            return false;
        }

    }
}
