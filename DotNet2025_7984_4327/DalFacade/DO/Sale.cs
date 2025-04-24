
namespace DO;

public record Sale(
    int SaleId,
    int SaleProductId,
    int? RequiredQuantityForDiscount,
    bool IsIntendedForAllCustomers, //מציין אם המבצע מיועד לכלל הלקוחות או רק חברי מועדון
    int FinalPrice,
    DateTime SaleStartDate,
    DateTime? SaleEndDate
    )

{
    public Sale() : this(11, 1, 2, true, 100, DateTime.Now, DateTime.Now) { }

}

