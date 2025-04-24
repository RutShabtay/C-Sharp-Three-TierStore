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
    internal class OrderImplementation : IOrder
    {
        private IDal _dal = DalApi.Factory.Get;

        List<SaleInProduct>? AddProductToOrder(Order order, int productId, int quantity);
        void CalcTotalPriceForProduct(ProductInOrder product);
        void CalcTotalPrice(Order order);
        void DoOrder(Order order);
        void SearchSaleForProduct(ProductInOrder product, bool isPreferredCustomer)
        {
            List<SaleInProduct>? tempSaleList = ProductImplementation.SalesInProduct(product.productId, isPreferredCustomer);
            tempSaleList?.Select(x => (x.QuantityForSale <= product.quantityInOrder) && (x.isIntendedForAllCustomers || isPreferredCustomer)).ToList();
        }

    }
}
