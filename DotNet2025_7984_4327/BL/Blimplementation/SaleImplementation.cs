using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class SaleImplementation
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            return _dal.Sale.Create(item.SaleToDo());
        }
        public BO.Sale? Read(int id)
        {
            return _dal.Sale.Read(id)?.SaleToBo();
        }
        public BO.Sale? Read(Func<DO.Sale, bool> filter)
        {
            return _dal.Sale.Read(filter)?.SaleToBo();

        }
        public List<BO.Sale> ReadAll(Func<DO.Sale, bool>? filter = null)
        {
            return _dal.Sale.ReadAll(filter)?.Select(q => q.SaleToBo()).ToList() ?? new List<BO.Sale>();

        }
        public void Update(BO.Sale item)
        {
            _dal.Sale.Update(item.SaleToDo());

        }
        public void Delete(int id)
        {
            _dal.Sale.Delete(id);
        }
    }
}
