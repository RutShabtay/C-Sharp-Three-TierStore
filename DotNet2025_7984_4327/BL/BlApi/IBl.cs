
namespace BlApi
{
    public interface IBl
    {
        ICustomer ICustomer { get; }
        IOrder IOrder { get; }
        IProduct IProduct { get; }
        ISale ISale { get; }
    }
}
