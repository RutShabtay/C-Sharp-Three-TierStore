using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; init; }
        public int? QuantityForSale { get; set; }
        public double price { get; set; }
        public bool isIntendedForAllCustomers { get; set; }

    }
}
