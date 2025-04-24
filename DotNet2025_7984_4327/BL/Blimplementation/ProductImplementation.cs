using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class ProductImplementation : BlApi.IProduct
    {
        private IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.ProductToDo());
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }
        }
        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id)?.ProductToBo();
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }

        }
        public BO.Product? Read(Func<DO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(filter)?.ProductToBo();
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }
        }
        public List<BO.Product> ReadAll(Func<DO.Product, bool>? filter = null)
        {
            try
            {
                return _dal.Product.ReadAll(filter)?.Select(q => q.ProductToBo()).ToList() ?? new List<BO.Product>();
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }
        }
        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ProductToDo());
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }
        }

        public void salesInProduct(int productId, bool isPreferredCustomer)
        {
            List<DO.Sale> allSales;
            try
            {
                allSales = _dal.Sale.ReadAll();
            }
            catch (Exception ex)
            {
                throw new BO.BlDeliverDalException(ex, ex.Message);
            }

            allSales.Select(s => s.productId == productId && s.saleStartDate <= DateTime.Today && s.saleEndDate >= DateTime.Today).ToList();
            (allSales.Select(s => s.saleToSaleInProduct()).ToList() ?? new List<SaleInProduct>());

        }
    }
}
