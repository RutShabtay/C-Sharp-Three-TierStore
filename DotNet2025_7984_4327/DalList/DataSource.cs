namespace Dal;
using DO;
using DalFacade;
static internal class DataSource
{

    static internal class Config
    {
        internal const int beginningIndexSale = 0;
        internal const int beginningIndexProduct = 0;
        internal const int beginningIndexCustomer = 0;

        private static int prevIndexSale = beginningIndexSale;
        private static int prevIndexProduct = beginningIndexProduct;
        private static int prevIndexCustomer = beginningIndexCustomer;

        static int getIndexSale()
        {

            return prevIndexSale++;

        }
        static int getIndexProduct()
        {

            return prevIndexProduct++;

        }
        static int getIndexCustomer()
        {

            return prevIndexCustomer++;

        }


    }
    static internal List<Product>? Products = new List<Product>();
    static internal List<Sale>? Sales = new List<Sale>();
    static internal List<Customer>? Customers = new List<Customer>();
}
