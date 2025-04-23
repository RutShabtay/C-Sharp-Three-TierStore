
using DO;
using DalApi;
namespace DalTest;



public class Intialization
{
    private static IDal? s_dal;

    private static void createCustomers()
    {
        s_dal.Customer.Create(new Customer(328187985, "Reut", "Shderot 8", "0578211450"));
        s_dal.Customer.Create(new Customer(318187935, "Hadas", "King Jorg 11", "0574431250"));
        s_dal.Customer.Create(new Customer(324187935, "Avigail", "Tzipory 9", "0548541650"));

    }

    private static void createProducts()
    {
        s_dal.Product.Create(new Product(2, "DisneyPajamas", Catagories.Pajamas, 120, 52));
        s_dal.Product.Create(new Product(3, "Chanel Bleu de Chanel", Catagories.perfume, 620, 20));
        s_dal.Product.Create(new Product(4, "Fur slippers", Catagories.slippers, 80, 152));
        s_dal.Product.Create(new Product(5, "TomAndJerryPajamas", Catagories.Pajamas, 198, 70));
        s_dal.Product.Create(new Product(6, "Versace Eros", Catagories.perfume, 780, 12));

    }

    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(22, 1, 2, true, 100, new DateTime(2024, 11, 20), new DateTime(2024, 12, 10)));
        s_dal.Sale.Create(new Sale(33, 2, 5, false, 150, new DateTime(2025, 01, 01), new DateTime(2025, 01, 22)));
        s_dal.Sale.Create(new Sale(44, 3, 1, true, 120, new DateTime(2024, 12, 01), new DateTime(2025, 12, 20)));

    }
    public static void initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }

}
