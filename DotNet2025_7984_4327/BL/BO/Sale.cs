using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int SaleId { get; init; }
        public int SaleProductId { get; init; }
        public int? RequiredQuantityForDiscount { get; set; }
        public bool IsIntendedForAllCustomers { get; set; }
        public int FinalPrice { get; set; }
        public DateTime SaleStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public override string ToString() => this.ToStringProperty();


    }
}
