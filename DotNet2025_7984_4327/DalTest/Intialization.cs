
using DO;
using DalApi;
namespace DalTest;



public class Intialization
{
    private static IDal? s_dal;

    private static void createCustomers()
    {
        s_dal.Customer.Create(new Customer(328187985, "Reut", "Shderot 8", "0578211450"));
        s_dal.Customer.Create(new Customer(213456789, "Noa", "Herzl 10, Tel Aviv", "0541234567"));
        s_dal.Customer.Create(new Customer(987654321, "Yael", "Ben Gurion 45, Haifa", "0527654321"));
        s_dal.Customer.Create(new Customer(456789123, "Avigail", "Dizengoff 99, Netanya", "0509988776"));
        s_dal.Customer.Create(new Customer(112233445, "Hodaya", "Rothschild 3, Rishon Lezion", "0538877665"));
        s_dal.Customer.Create(new Customer(998877665, "Tamar", "Begin 21, Petah Tikva", "0587654321"));
        s_dal.Customer.Create(new Customer(334455667, "Shira", "Keren Hayesod 12, Eilat", "0561122334"));
        s_dal.Customer.Create(new Customer(778899001, "Rivka", "HaPalmach 7, Jerusalem", "0549988771"));
        s_dal.Customer.Create(new Customer(667788990, "Michal", "Neve Shaanan 5, Be'er Sheva", "0501231234"));
        s_dal.Customer.Create(new Customer(445566778, "Batya", "Yehuda Halevi 6, Bnei Brak", "0524567890"));
        s_dal.Customer.Create(new Customer(556677889, "Adina", "HaRav Kook 13, Modiin", "0559988776"));
        s_dal.Customer.Create(new Customer(223344556, "Lea", "HaHistadrut 4, Ashdod", "0536655443"));
        s_dal.Customer.Create(new Customer(889900112, "Esther", "Emek Refaim 8, Jerusalem", "0573322110"));
        s_dal.Customer.Create(new Customer(112211221, "Nava", "Shivtei Israel 11, Lod", "0507766554"));
        s_dal.Customer.Create(new Customer(991122334, "Odelia", "Hashalom 14, Ra'anana", "0547891234"));

    }

    private static void createProducts()
    {
        // Necklaces
        s_dal.Product.Create(new Product(1, "GoldenGrace Necklace", Catagories.Necklaces, 250, 20));
        s_dal.Product.Create(new Product(2, "PearlTouch Necklace", Catagories.Necklaces, 180, 35));
        s_dal.Product.Create(new Product(3, "Twilight Charm", Catagories.Necklaces, 220, 15));

        // Bracelets
        s_dal.Product.Create(new Product(4, "RoseGold Bracelet", Catagories.Bracelets, 150, 40));
        s_dal.Product.Create(new Product(5, "OceanBeads Bracelet", Catagories.Bracelets, 120, 60));
        s_dal.Product.Create(new Product(6, "SilverSpark Bracelet", Catagories.Bracelets, 135, 50));

        // Earrings
        s_dal.Product.Create(new Product(7, "LunaDrop Earrings", Catagories.Earrings, 90, 70));
        s_dal.Product.Create(new Product(8, "CrystalBloom Earrings", Catagories.Earrings, 110, 55));
        s_dal.Product.Create(new Product(9, "DaintyHoop Earrings", Catagories.Earrings, 95, 65));

        // Rings
        s_dal.Product.Create(new Product(10, "Infinity Ring", Catagories.Rings, 200, 30));
        s_dal.Product.Create(new Product(11, "EmeraldShine Ring", Catagories.Rings, 275, 25));
        s_dal.Product.Create(new Product(12, "VelvetGold Ring", Catagories.Rings, 230, 20));

        // Watches
        s_dal.Product.Create(new Product(13, "Midnight Classic Watch", Catagories.Watches, 320, 18));
        s_dal.Product.Create(new Product(14, "RoseTime Watch", Catagories.Watches, 280, 22));
        s_dal.Product.Create(new Product(15, "SteelChrono Watch", Catagories.Watches, 350, 12));

    }

    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(1, 2, 1, false, 100, new DateTime(2025, 5, 2), new DateTime(2025, 5, 12)));
        s_dal.Sale.Create(new Sale(2, 5, null, true, 95, new DateTime(2025, 5, 6), new DateTime(2025, 5, 16)));
        s_dal.Sale.Create(new Sale(3, 6, 3, true, 150, new DateTime(2025, 5, 3), new DateTime(2025, 5, 10)));
        s_dal.Sale.Create(new Sale(4, 9, 2, false, 80, new DateTime(2025, 5, 7), new DateTime(2025, 5, 20)));
        s_dal.Sale.Create(new Sale(5, 10, null, true, 140, new DateTime(2025, 5, 1), new DateTime(2025, 5, 14)));
        s_dal.Sale.Create(new Sale(6, 13, 2, false, 195, new DateTime(2025, 5, 5), new DateTime(2025, 5, 25)));
        s_dal.Sale.Create(new Sale(7, 15, null, true, 220, new DateTime(2025, 5, 9), new DateTime(2025, 5, 30)));
        s_dal.Sale.Create(new Sale(8, 16, 1, false, 105, new DateTime(2025, 5, 4), new DateTime(2025, 5, 18)));
        s_dal.Sale.Create(new Sale(9, 18, 2, true, 130, new DateTime(2025, 6, 1), new DateTime(2025, 6, 10)));
        s_dal.Sale.Create(new Sale(10, 20, null, false, 85, new DateTime(2025, 6, 5), new DateTime(2025, 6, 15)));
        s_dal.Sale.Create(new Sale(11, 22, 3, true, 160, new DateTime(2025, 6, 3), new DateTime(2025, 6, 12)));
        s_dal.Sale.Create(new Sale(12, 24, 1, false, 115, new DateTime(2025, 6, 7), new DateTime(2025, 6, 20)));
        s_dal.Sale.Create(new Sale(13, 26, null, true, 190, new DateTime(2025, 6, 2), new DateTime(2025, 6, 17)));
        s_dal.Sale.Create(new Sale(14, 28, 2, false, 210, new DateTime(2025, 6, 6), new DateTime(2025, 6, 25)));
        s_dal.Sale.Create(new Sale(15, 30, null, true, 99, new DateTime(2025, 6, 9), new DateTime(2025, 6, 30)));
        s_dal.Sale.Create(new Sale(16, 1, 2, false, 90, new DateTime(2025, 6, 10), new DateTime(2025, 6, 20)));
        s_dal.Sale.Create(new Sale(17, 3, null, true, 180, new DateTime(2025, 6, 12), new DateTime(2025, 6, 25)));
        s_dal.Sale.Create(new Sale(18, 4, 1, false, 110, new DateTime(2025, 6, 14), new DateTime(2025, 6, 24)));
        s_dal.Sale.Create(new Sale(19, 7, null, true, 75, new DateTime(2025, 6, 15), new DateTime(2025, 6, 28)));
        s_dal.Sale.Create(new Sale(20, 8, 3, false, 170, new DateTime(2025, 6, 17), new DateTime(2025, 6, 27)));
        s_dal.Sale.Create(new Sale(21, 11, 2, true, 145, new DateTime(2025, 6, 19), new DateTime(2025, 6, 30)));
        s_dal.Sale.Create(new Sale(22, 12, null, false, 135, new DateTime(2025, 6, 21), new DateTime(2025, 7, 2)));
        s_dal.Sale.Create(new Sale(23, 14, 1, true, 155, new DateTime(2025, 6, 22), new DateTime(2025, 7, 3)));
        s_dal.Sale.Create(new Sale(24, 17, 2, false, 125, new DateTime(2025, 6, 24), new DateTime(2025, 7, 4)));
        s_dal.Sale.Create(new Sale(25, 19, null, true, 165, new DateTime(2025, 6, 25), new DateTime(2025, 7, 5)));

    }
    public static void initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }

}
