using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool isPreferredCustomer { get; set; }
        public List<ProductInOrder> productsInOrder { get; set; }
        public double price { get; set; }  
    }
}
