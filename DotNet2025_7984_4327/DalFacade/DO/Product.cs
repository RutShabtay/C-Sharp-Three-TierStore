namespace DO;

public record Product(
    int ProductId,
    string ProductName,
    Catagories? Catagory,
    double ProductPrice,
    int QuantityInStock
    )
{
    public Product() : this(0, "", null, 0, 0) { }

}
