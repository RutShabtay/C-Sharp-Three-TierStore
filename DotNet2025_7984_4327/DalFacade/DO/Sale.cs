
namespace DO;

public record Sale(int saleId, int productId, int? requiredQuantityForDiscount, bool isIntendedForAllCustomers, int finalPrice, DateTime saleStartDate, DateTime? saleEndDate)

{
    public Sale() : this(11, 1, 2, true, 100, DateTime.Now, DateTime.Now) { }

}

