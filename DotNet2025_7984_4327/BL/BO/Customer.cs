using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int customerId { get; init; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerPhone { get; set; }
    }
}
