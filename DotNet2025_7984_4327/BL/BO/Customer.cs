using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerPhone { get; set; }
        public override string ToString() => this.ToStringProperty();

        public Customer() { }
        public Customer(int customerId, string customerName, string customerAddress, string customerPhone)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerPhone = customerPhone;
        }
    }
}
