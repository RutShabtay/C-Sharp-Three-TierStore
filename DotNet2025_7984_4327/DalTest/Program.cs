using DO;
using DalTest;
using System.Runtime.CompilerServices;
using DalApi;
using System.Reflection;



public class program
{
    private static IDal s_dal = DalApi.Factory.Get;
    private static void DisplayMainMenue()
    {
        Console.WriteLine("please, choose  kind of object: customer/product/sale/clearLog");
        string kindOfObject = Console.ReadLine();
        switch (kindOfObject.ToLower())
        {
            case "customer":
                ICrud<Customer> Customer = s_dal.Customer;
                DisplayCrud(Customer, "customer");
                break;
            case "sale":
                ICrud<Sale> Sale = s_dal.Sale;
                DisplayCrud(Sale, "sale");

                break;
            case "product":
                ICrud<Product> Product = s_dal.Product;
                DisplayCrud(Product, "product");
                break;
            case "clearlog":
                Tools.LogManager.DeleteOldDirectorys();
                break;

        }

    }


    private static void DisplayCrud<T>(ICrud<T> obj, string type)
    {
        int Id;
        Console.WriteLine("please,choose func to do: create/read/read All/update/delete/ for exit press EXIT");
        string kindOfFunc = Console.ReadLine();
        while (kindOfFunc != "EXIT")
        {
            switch (kindOfFunc.ToLower())
            {
                case "create":
                    switch (type.ToLower())
                    {
                        case "customer":
                            Customer c = (Customer)CreateObject("customer");
                            s_dal.Customer.Create(c);
                            break;
                        case "product":
                            Product p = (Product)CreateObject("product");
                            s_dal.Product.Create(p);
                            break;
                        case "sale":
                            Sale s = (Sale)CreateObject("sale");
                            s_dal.Sale.Create(s);

                            break;
                    }
                    break;
                case "read":
                    Console.WriteLine("Insert ID.");
                    Id = int.Parse(Console.ReadLine());
                    Console.WriteLine(obj.Read(Id));
                    Console.WriteLine("Successfully");
                    break;
                case "read all":
                    List<T> list = obj.ReadAll();
                    list.ForEach(x => Console.WriteLine(x));
                    break;
                case "update":
                    switch (type.ToLower())
                    {
                        case "customer":
                            Customer c = (Customer)CreateObject("customer");
                            s_dal.Customer.Update(c);
                            break;
                        case "product":
                            Product p = (Product)CreateObject("product");
                            s_dal.Product.Update(p);
                            break;
                        case "sale":
                            Sale s = (Sale)CreateObject("sale");
                            s_dal.Sale.Update(s);

                            break;
                    }
                    break;
                case "delete":
                    Console.WriteLine("Insert ID.");
                    Id = int.Parse(Console.ReadLine());
                    obj.Delete(Id);
                    Console.WriteLine("Successfully");
                    break;


            }
            Console.WriteLine("please,choose func to do: create/read/read All/update/delete for exit press EXIT");
            kindOfFunc = Console.ReadLine();

        }


    }

    private static Object CreateObject(String kindOfObject)
    {
        switch (kindOfObject.ToLower())
        {
            case "customer":
                Console.WriteLine("Insert details: customerId,customerName,customerAdress,customerPhone");
                int customerId = Convert.ToInt32(Console.ReadLine());

                string? customerName = Console.ReadLine();
                string? customerAdress = Console.ReadLine();
                string? customerPhone = Console.ReadLine();
                Customer c = new Customer(customerId, customerName, customerAdress, customerPhone);
                return c;
                break;
            case "sale":
                Console.WriteLine("Insert details: saleId,saleProductId,requiredQuantityForDiscount,isIntendedForAllCustomers,finalPrice,saleStartDate,convertaleStartDate,convertsaleEndDate");
                int saleId = Convert.ToInt32(Console.ReadLine());
                int saleProductId = Convert.ToInt32(Console.ReadLine());
                int requiredQuantityForDiscount = Convert.ToInt32(Console.ReadLine());
                string isIntendedForAllCustomers = Console.ReadLine();
                bool.TryParse(isIntendedForAllCustomers, out bool result);
                int finalPrice = Console.Read();
                string saleStartDate = Console.ReadLine();
                DateTime convertaleStartDate = DateTime.Parse(saleStartDate);
                string saleEndDate = Console.ReadLine();
                DateTime convertsaleEndDate = DateTime.Parse(saleEndDate);
                Sale s = new Sale(saleId, saleProductId, requiredQuantityForDiscount, result, finalPrice, convertaleStartDate, convertsaleEndDate);
                return s;
                break;
            case "product":
                Console.WriteLine("Insert details: productId,productName,catagory,productPrice,quantityInStock");
                int productId = Convert.ToInt32(Console.ReadLine());
                string? productName = Console.ReadLine();
                string? catagory = Console.ReadLine();
                Enum.TryParse(catagory, true, out Catagories choseCatagory);
                int productPrice = Convert.ToInt32(Console.ReadLine());
                int quantityInStock = Convert.ToInt32(Console.ReadLine());
                Product p = new Product(productId, productName, choseCatagory, productPrice, quantityInStock);
                return p;
                break;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Intialization.initialize();
        DisplayMainMenue();
    }
}
