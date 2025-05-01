
namespace DO;


public record Customer(int customerId,
    string customerName,
    string customerAddress,
    string customerPhone)
{

    public Customer() : this(0, null, null, null) { }

}
