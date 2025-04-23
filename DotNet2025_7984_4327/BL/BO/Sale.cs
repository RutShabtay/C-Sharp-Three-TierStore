using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int saleId { get; init; }
        public int productId { get; init; }
        public int? requiredQuantityForDiscount { get; set; }
        public bool isIntendedForAllCustomers { get; set; }
        public int finalPrice { get; set; }
        public DateTime saleStartDate { get; set; }
        public DateTime? saleEndDate { get; set; }

    }
}
