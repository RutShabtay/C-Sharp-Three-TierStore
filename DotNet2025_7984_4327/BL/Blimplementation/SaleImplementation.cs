using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class SaleImplementation : BlApi.ISale
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.SaleToDo());

            }
            catch (Exception ex)
            {
                throw new BO.BlAlreadyExistsIdException("", ex);
            }
        }
        public BO.Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id)?.SaleToBo();
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }
        }
        public BO.Sale? Read(Func<DO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(filter)?.SaleToBo();
            }

            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }

        }
        public List<BO.Sale> ReadAll(Func<DO.Sale, bool>? filter = null)
        {
            try
            {
                return _dal.Sale.ReadAll(filter)?.Select(q => q.SaleToBo()).ToList() ?? new List<BO.Sale>();

            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occured in func ReadAll" + ex.Message);
            }

        }
        public void Update(BO.Sale item)
        {
            try
            {
                _dal.Sale.Update(item.SaleToDo());
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
                _dal.Sale.Delete(id);
            }
            catch (Exception ex)
            {
                throw new BO.BlNotExistsIdException("", ex);
            }

        }
    }
}
