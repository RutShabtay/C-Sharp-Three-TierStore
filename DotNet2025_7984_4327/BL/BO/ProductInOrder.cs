using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int productId { get; init; }
        public string productName { get; set; }
        public double basePrice { get; set; }
        public int quantityInOrder { get; set; }
        public List<SaleInProduct>? saleLstPerProduct { get; set; }
        public double finalPrice { get; set; }

    }
}
