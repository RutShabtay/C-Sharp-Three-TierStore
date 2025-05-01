using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int SaleProductId { get; set; }
        public int? RequiredQuantityForDiscount { get; set; }
        public bool IsIntendedForAllCustomers { get; set; }
        public double FinalPrice { get; set; }
        public DateTime SaleStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public override string ToString() => this.ToStringProperty();

        public Sale() { }
        public Sale(int saleId, int saleProductId, int? requiredQuantityForDiscount, bool isIntendedForAllCustomers, int finalPrice, DateTime saleStartDate, DateTime? saleEndDate)
        {
            SaleId = saleId;
            SaleProductId = saleProductId;
            RequiredQuantityForDiscount = requiredQuantityForDiscount;
            IsIntendedForAllCustomers = isIntendedForAllCustomers;
            FinalPrice = finalPrice;
            SaleStartDate = saleStartDate;
            SaleEndDate = saleEndDate;
        }
    }
}
