using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; init; }
        public int? QuantityForSale { get; set; }
        public double Price { get; set; }
        public bool IsIntendedForAllCustomers { get; set; }

        public SaleInProduct() { }
        public SaleInProduct(int saleId, int? quantityForSale, double price, bool isIntendedForAllCustomers)
        {
            SaleId = saleId;
            QuantityForSale = quantityForSale;
            Price = price;
            IsIntendedForAllCustomers = isIntendedForAllCustomers;
        }

        public override string ToString() => this.ToStringProperty();


    }
}
