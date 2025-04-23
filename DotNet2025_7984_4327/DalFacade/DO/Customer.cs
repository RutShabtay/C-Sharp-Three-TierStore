
namespace DO;


public record Customer(int customerId, string customerName, string customerAddress, string customerPhone)
{
    public Customer() : this(328187984, "Hilana", "Nacliel 7", "0548211650") { }

}
