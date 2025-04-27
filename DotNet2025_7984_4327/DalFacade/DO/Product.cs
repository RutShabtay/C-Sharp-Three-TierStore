namespace DO;


public record Product(
    int productId,
    string productName,
    Catagories? catagory,
    double productPrice,
    int quantityInStock
    )
{
    public Product() : this(0, "", null, 0, 0) { }

}
