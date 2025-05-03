using DalApi;
namespace Dal;

internal sealed class DalList:IDal
{
    //static instance because a static function can only access static variables.
    static readonly DalList instance= new DalList();
    //static method to be able to access from outer class to instance variable.
    public static DalList Instance { get { return instance; } }

    //private constructore
    private DalList() { }

    public ICustomer Customer => new CustomerImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();

}
