using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {

        List<SaleInProduct>? AddProductToOrder(Order order, int productId, int quantity);
        void CalcTotalPriceForProduct(ProductInOrder product, bool isPreferredCustomer);
        void CalcTotalPrice(Order order);
        void DoOrder(Order order);
        List<BO.SaleInProduct>? SearchSaleForProduct(ProductInOrder product, bool isPreferredCustomer);

    }
}
