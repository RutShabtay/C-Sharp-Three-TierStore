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
                throw new BO.BlAlreadyExistsIdException("", ex);
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
                throw new BO.BlNotExistsIdException("", ex);
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
                throw new BO.BlNotExistsIdException("", ex);
            }
        }
        public List<BO.Product> ReadAll(Func<DO.Product, bool>? filter = null)
        {
            try
            {
               List<BO.Product> products= _dal.Product.ReadAll(filter)?.Select(q => q.ProductToBo()).ToList() ?? new List<BO.Product>();
                products.ForEach(product => product.saleInProducts = GetActiveSales(product.productId));
                return products;
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occured if func: BL-ReadAll " + ex.Message);
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
                throw new BO.BlNotExistsIdException("", ex);
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
                throw new BO.BlNotExistsIdException("", ex);
            }
        }

        //קבלת כל המבצעים של מוצר מסויים ללא סינון של כמות תקינה
        public List<BO.SaleInProduct>? GetActiveSales(int productId/*, bool IsPreferredCustomer*/)
        {
            try
            {
                //קבלת כל המבצעים
                List<DO.Sale> allSales = _dal.Sale.ReadAll();

                //סינון מבצע של אותו מוצר
                allSales = (from s in allSales
                            where s.SaleProductId == productId
                            select s).ToList();

                

                //המרה לרשימה המתאימה לשכבה כולל סינון מבצעים לפי תוקף
                List<BO.SaleInProduct> saleListInProductBO = (from s in allSales
                                                              where s.SaleStartDate <= DateTime.Now && s.SaleEndDate <= DateTime.Now
                                                              select new BO.SaleInProduct(s.SaleId, s.RequiredQuantityForDiscount, s.FinalPrice, s.IsIntendedForAllCustomers)).ToList();

                return saleListInProductBO.OrderBy(p => p.Price / p.QuantityForSale).ToList();
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occured in func GetActiveSales " + ex.Message);
            }

        }


    }
}



