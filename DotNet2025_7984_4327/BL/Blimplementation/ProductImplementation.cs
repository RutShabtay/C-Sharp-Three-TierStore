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
                BO.Product? product = _dal.Product.Read(id)?.ProductToBo();
                product.SaleInProducts = GetActiveSales(product.ProductId);
                return product;
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
                BO.Product? product = _dal.Product.Read(filter)?.ProductToBo();
                product.SaleInProducts = GetActiveSales(product.ProductId);
                return product;
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
                List<DO.Product?> listDO = _dal.Product.ReadAll();

                List<BO.Product?> listBO;

                if (filter == null)
                {
                    listBO = (from c in listDO
                              select c.ProductToBo()).ToList();
                }
                else
                {

                    listBO = (from c in listDO
                              where filter(c)
                              select c.ProductToBo()).ToList();
                }

                foreach (var product in listBO)
                {
                    product.SaleInProducts = GetActiveSales(product.ProductId);
                }

                return listBO;
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
        public List<BO.SaleInProduct>? GetActiveSales(int productId, bool isPreferredCustomer = true)
        {
            try
            {
                //קבלת כל המבצעים
                List<DO.Sale> allSales = _dal.Sale.ReadAll();

                //סינון מבצע של אותו מוצר
                allSales = (from s in allSales
                            where s.SaleProductId == productId
                            select s).ToList();

                //במידה ויש צורך לסנן ע"פ לקוח מועדף
                if (!isPreferredCustomer)
                {
                    allSales = (from s in allSales
                                where s.IsIntendedForAllCustomers == true
                                select s).ToList();

                }

                //המרה לרשימה המתאימה לשכבה כולל סינון מבצעים לפי תוקף
                List<BO.SaleInProduct> saleListInProductBO = (from s in allSales
                                                              where s.SaleStartDate <= DateTime.Now && s.SaleEndDate >= DateTime.Now
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



