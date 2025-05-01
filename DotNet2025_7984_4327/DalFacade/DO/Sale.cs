
namespace DO;

public record Sale(
    int SaleId,
    int SaleProductId,
    int? RequiredQuantityForDiscount,
    bool IsIntendedForAllCustomers, //מציין אם המבצע מיועד לכלל הלקוחות או רק חברי מועדון
    double FinalPrice,
    DateTime SaleStartDate,
    DateTime? SaleEndDate
    )

{
    public Sale() : this(0, 0, 0, false, 0, DateTime.Now, DateTime.Now) { }

}

