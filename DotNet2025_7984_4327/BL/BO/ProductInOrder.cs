using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public double basePrice { get; set; }
        public int quantityInOrder { get; set; }
        public List<SaleInProduct>? saleListPerProduct { get; set; }
        public double finalPrice { get; set; }

        public ProductInOrder() { }
        public ProductInOrder(int productId, string productName, double basePrice, int quantityInOrder, List<SaleInProduct>? saleListPerProduct, double finalPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.basePrice = basePrice;
            this.quantityInOrder = quantityInOrder;
            this.saleListPerProduct =new List<SaleInProduct>();
            this.finalPrice = finalPrice;
        }
        public override string ToString() => this.ToStringProperty();

    }
}
