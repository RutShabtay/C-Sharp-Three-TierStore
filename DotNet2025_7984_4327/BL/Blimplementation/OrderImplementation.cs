using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blimplementation
{
    internal class OrderImplementation : IOrder
    {
        private IDal _dal = DalApi.Factory.Get;
        private IBl _bl = BlApi.Factory.Get;


        public List<SaleInProduct>? AddProductToOrder(Order order, int productId, int quantity)
        {
            Product product;
            try
            {
                product = _dal.Product.Read(productId).ProductToBo();
            }
            catch (BlNotExistsIdException ex)
            {
                throw new BlNotExistsIdException("Not Available Item 😣");
            }
            ProductInOrder? updateProduct = order.ProductsInOrder.Find(p => p.productId == productId);
            try
            {
                if (product.QuantityInStock < quantity)
                    throw new BlInvalidQuantity("Out of stock 😣");

                if (updateProduct != null)
                {
                    if (updateProduct.quantityInOrder + quantity < 0)
                        throw new BlInvalidQuantity("Operation not possible. Add more of this quantity so that you can remove this quantity 😉");
                    if (updateProduct.quantityInOrder + quantity == 0)
                    {
                        order.ProductsInOrder.RemoveAll(p => p.productId == productId);
                        CalcTotalPrice(order);
                        return null;
                    }
                    updateProduct.quantityInOrder += quantity;
                    order.ProductsInOrder = order.ProductsInOrder.Select(p => p.productId == productId ? updateProduct : p).ToList();
                    product.QuantityInStock -= quantity;
                    product.SaleInProducts = SearchSaleForProduct(updateProduct, order.IsPreferredCustomer);
                    _dal.Product.Update(product.ProductToDo());
                }
                else
                {
                    if (quantity <= 0)
                    {
                        throw new BlInvalidQuantity("Operation not possible. Add more of this quantity so that you can remove this quantity 😉");
                    }

                    order.ProductsInOrder.Add(new ProductInOrder(product.ProductId, product.ProductName, product.ProductPrice, quantity, null, quantity * product.ProductPrice));
                    ProductInOrder? updateProductInOrder = order.ProductsInOrder.Find(p => p.productId == product.ProductId);

                    updateProductInOrder.saleListPerProduct = SearchSaleForProduct(updateProductInOrder, order.IsPreferredCustomer);

                }
                CalcTotalPrice(order);
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException(ex.Message);
            }
            return order.ProductsInOrder.Find(p => p.productId == productId)?.saleListPerProduct;
        }


        //חישוב מחיר סופי למוצר כולל אחרי הנחה ע"י רשימת המבצעים
        public void CalcTotalPriceForProduct(ProductInOrder product, bool isPreferredCustomer)
        {
            try
            {
                double totalPrice = 0;
                int count = product.quantityInOrder;
                List<BO.SaleInProduct>? allSalesForProduct = SearchSaleForProduct(product, isPreferredCustomer);

                if (product.saleListPerProduct == null)
                {
                    totalPrice = _dal.Product.Read(product.productId).ProductPrice * product.quantityInOrder;
                    product.finalPrice = totalPrice;
                    return;
                }

                product.saleListPerProduct.ForEach(x =>
                {
                    if (x.QuantityForSale == 0)
                    {
                        throw new BO.BlInvalidQuantity("Quantity 0 is Invalid");
                    }

                    if (count > 0)
                        if (product.quantityInOrder >= x.QuantityForSale)
                        {
                            totalPrice += (double)(((int)product.quantityInOrder / x.QuantityForSale) * x.Price);
                            count -= (int)(product.quantityInOrder / x.QuantityForSale * x.QuantityForSale);
                            product.saleListPerProduct.Append(x);
                        }
                });
                if (count > 0)
                {
                    totalPrice += count * product.basePrice;
                }
                product.finalPrice = totalPrice;
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occured in Func: SearchSaleForProduct " + ex.Message);
            }
        }

        public void CalcTotalPrice(Order order)
        {
            double orderTotalPrice = 0;
            order.ProductsInOrder.ForEach(p => { CalcTotalPriceForProduct(p, order.IsPreferredCustomer); });
            order.ProductsInOrder.ForEach(p => { orderTotalPrice += p.finalPrice; });
            order.OrderTotalPrice = orderTotalPrice;
        }


        public void DoOrder(Order order)
        {
            order.ProductsInOrder.ForEach(p =>
            {
                BO.Product? productToUpdate = _dal.Product.Read(p.productId).ProductToBo();
                productToUpdate.QuantityInStock -= p.quantityInOrder;
                _dal.Product.Update(productToUpdate.ProductToDo());
            });
        }


        //קבלת כל המבצעים למוצר כולל סינון של כמות תקינה
        public List<BO.SaleInProduct> SearchSaleForProduct(ProductInOrder product, bool isPreferredCustomer)
        {
            try
            {
                if (product == null)
                {
                    return new List<BO.SaleInProduct>(); // או זרקי שגיאה אם זה מקרה נדיר

                }

                var saleListForSpecProduct = _bl.IProduct.GetActiveSales(product.productId, isPreferredCustomer)
                                             ?? new List<BO.SaleInProduct>();

                if (!isPreferredCustomer)
                {
                    saleListForSpecProduct = saleListForSpecProduct
                        .FindAll(s => s.IsIntendedForAllCustomers == true);
                }

                saleListForSpecProduct = saleListForSpecProduct
                    .Where(s => s.QuantityForSale <= product.quantityInOrder)
                    .ToList();

                return saleListForSpecProduct;
            }
            catch (Exception ex)
            {
                throw new BO.BlGeneralException("Error Occurred in Func: SearchSaleForProduct " + ex.Message);
            }
        }


    }


}
