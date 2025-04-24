using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool IsPreferredCustomer { get; set; }
        public List<ProductInOrder> ProductsInOrder { get; set; }
        public double OrderTotalPrice { get; set; }
        public override string ToString() => this.ToStringProperty();

        public Order() { }
    }
}
