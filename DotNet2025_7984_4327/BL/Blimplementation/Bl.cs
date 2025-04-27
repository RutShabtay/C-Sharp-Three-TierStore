using BlApi;

namespace Blimplementation
{
    internal class Bl : IBl
    {
        public ICustomer ICustomer => new CustomerImplementation();
        public IProduct IProduct => new ProductImplementation();
        public ISale ISale => new SaleImplementation();
        public IOrder IOrder => new OrderImplementation();
        public Bl() { }
    
    }
}
