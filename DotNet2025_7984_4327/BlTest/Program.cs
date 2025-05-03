using BO;
using DO;
using System.Runtime.InteropServices;

public class program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get;
    public static void DisplayMainMenu()
    {
        Console.WriteLine("customer-1 \nprinciple-2 \nback-0");
        int choose = int.Parse(Console.ReadLine());
        while (choose != 1 && choose != 2)
        {
            Console.WriteLine("Invalid choose. Insert again---");
            choose = int.Parse(Console.ReadLine());
        }
        switch (choose)
        {
            case 1:
                DisplayCustomerMenu();
                break;
            default:
                DisplayPrincipleMenu();
                break;

        }
    }

    public static void DisplayCustomerMenu()
    {
        Console.WriteLine("Insert customerID: ");
        int customerId = int.Parse(Console.ReadLine());
        if (s_bl.ICustomer.IsExists(customerId))
            Console.WriteLine("Hello " + s_bl.ICustomer.Read(customerId).CustomerName);
        else
            Console.WriteLine("casual customer");
        Order order = new Order();
        int choose = -1;
        while (choose != 6 && choose != 0)
        {
            Console.WriteLine("Product list-1 \n" +
            "Add product to cart-2 \n" +
            "Delete product-3 \n" +
            "View your cart-4 \n" +
            "Total price-5 \n" +
            "Make order-6");

            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    List<BO.Product> productList = s_bl.IProduct.ReadAll();
                    productList.ForEach(product => Console.WriteLine(product));
                    break;
                case 2:
                    Console.WriteLine("Insert productID and quantity");
                    int productId = int.Parse(Console.ReadLine());
                    int quantity = int.Parse(Console.ReadLine());
                    s_bl.IOrder.AddProductToOrder(order, productId, quantity);
                    break;
                case 3:
                    Console.WriteLine("Insert productID");
                    productId = int.Parse(Console.ReadLine());
                    s_bl.IOrder.AddProductToOrder(order, productId, -1);
                    break;
                case 4:
                    order.ProductsInOrder.ForEach(product => Console.WriteLine(product));
                    break;
                case 5:
                    Console.WriteLine(order.OrderTotalPrice);
                    break;
                case 6:
                    s_bl.IOrder.DoOrder(order);
                    break;
                case 0:
                    DisplayMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choose 😣");
                    break;

            }
        }
    }

    public static void DisplayPrincipleMenu()
    {
        int choose = -1;
        while (choose != 0)
        {
            Console.WriteLine("Customers-1 \n" +
            "Products-2 \n" +
            "Sales-3\n" +
            "Back-0");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    DisplayMainMenu();
                    break;
                case 1:
                    DisplayCustomer();
                    break;
                case 2:
                    DisplayProduct();
                    break;
                case 3:
                    DisplaySales();
                    break;
                default:
                    Console.WriteLine("Invalid choose---😣");
                    break;
            }
        }
    }

    public static void DisplayCustomer()
    {
        int choose = -1;
        while (choose != 0)
        {
            Console.WriteLine("All customers-1 \n" +
                "Spec customer-2 \n" +
                "Add customer-3 \n" +
                "Update customer-4 \n" +
                "Delete customer-5");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    DisplayMainMenu();
                    break;
                case 1:
                    List<BO.Customer> customerList = s_bl.ICustomer.ReadAll();
                    customerList.ForEach(customer => { Console.WriteLine(customer); });
                    break;
                case 2:
                    Console.WriteLine("insert customerID");
                    int customerID = int.Parse(Console.ReadLine());
                    BO.Customer customer = s_bl.ICustomer.Read(customerID);
                    Console.WriteLine(customer);
                    break;
                case 3:
                    Console.WriteLine("insert customerID, customerName, address, phone");
                    int customerId1 = int.Parse(Console.ReadLine());
                    string name1 = Console.ReadLine();
                    string address1 = Console.ReadLine();
                    string phone1 = Console.ReadLine();
                    BO.Customer customerToAdd = new BO.Customer(customerId1, name1, address1, phone1);
                    s_bl.ICustomer.Create(customerToAdd);
                    break;
                case 4:
                    Console.WriteLine("insert customerID, customerName, address, phone");
                    int customerId = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string address = Console.ReadLine();
                    string phone = Console.ReadLine();
                    BO.Customer customerToUpdate = new BO.Customer(customerId, name, address, phone);
                    s_bl.ICustomer.Update(customerToUpdate);
                    break;
                case 5:
                    Console.WriteLine("insert customerID");
                    int customerId2 = int.Parse(Console.ReadLine());
                    s_bl.ICustomer.Delete(customerId2);
                    break;
                default:
                    Console.WriteLine("invalid choose");
                    break;
            }
        }
    }

    public static void DisplayProduct()
    {
        int choose = -1;
        while (choose != 0)
        {
            Console.WriteLine("all product-1 \n" +
                "spec product-2 \n" +
                "add product-3 \n" +
                "update product-4 \n" +
                "delete product-5");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    DisplayMainMenu();
                    break;
                case 1:
                    List<BO.Product> productList = s_bl.IProduct.ReadAll();
                    productList.ForEach(product => { Console.WriteLine(product); });
                    break;
                case 2:
                    Console.WriteLine("insert productID");
                    int productID = int.Parse(Console.ReadLine());
                    BO.Product product = s_bl.IProduct.Read(productID);
                    Console.WriteLine(product);
                    break;
                case 3:
                    Console.WriteLine("insert productID, productName, category, price, amount");
                    int productId1 = int.Parse(Console.ReadLine());
                    string name1 = Console.ReadLine();
                    string category1 = Console.ReadLine();
                    int price1 = int.Parse(Console.ReadLine());
                    int amount1 = int.Parse(Console.ReadLine());
                    BO.Product productToAdd = new BO.Product(productId1, name1, BO.Catagories.Rings, price1, amount1, null);
                    s_bl.IProduct.Create(productToAdd);
                    break;
                case 4:
                    Console.WriteLine("insert productID, productName, category, price, amount");
                    int productId = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string category = Console.ReadLine();
                    int price = int.Parse(Console.ReadLine());
                    int amount = int.Parse(Console.ReadLine());
                    BO.Product productToUpdate = new BO.Product(productId, name, BO.Catagories.Rings, price, amount, null);
                    s_bl.IProduct.Update(productToUpdate);
                    break;
                case 5:
                    Console.WriteLine("insert productID");
                    int productId2 = int.Parse(Console.ReadLine());
                    s_bl.IProduct.Delete(productId2);
                    break;
                default:
                    Console.WriteLine("invalid choose");
                    break;
            }
        }
    }

    public static void DisplaySales()
    {
        int choose = -1;
        while (choose != 0)
        {
            Console.WriteLine("all sale-1 \n" +
                "spec sale-2 \n" +
                "add sale-3 \n" +
                "update sale-4 \n" +
                "delete sale-5");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    DisplayMainMenu();
                    break;
                case 1:
                    List<BO.Sale> saleList = s_bl.ISale.ReadAll();
                    saleList.ForEach(sale => { Console.WriteLine(sale); });
                    break;
                case 2:
                    Console.WriteLine("Insert saleID");
                    int saleID = int.Parse(Console.ReadLine());
                    BO.Sale sale = s_bl.ISale.Read(saleID);
                    Console.WriteLine(sale);
                    break;
                case 3:
                    Console.WriteLine("Insert saleId, productId, requiredQuantityForDiscount, isIntendedForAllCustomers, finalPrice, saleStartDate, saleEndDate");
                    int saleId1 = int.Parse(Console.ReadLine());
                    int productId1 = int.Parse(Console.ReadLine());
                    int requiredQuantityForDiscount1 = int.Parse(Console.ReadLine());
                    bool isIntendedForAllCustomers1 = bool.Parse(Console.ReadLine());
                    int finalPrice1 = int.Parse(Console.ReadLine());
                    DateTime saleStartDate1 = DateTime.Parse(Console.ReadLine());
                    DateTime saleEndDate1 = DateTime.Parse(Console.ReadLine());
                    BO.Sale saleToAdd = new BO.Sale(saleId1, productId1, requiredQuantityForDiscount1, isIntendedForAllCustomers1, finalPrice1, saleStartDate1, saleEndDate1);
                    s_bl.ISale.Update(saleToAdd);
                    break;
                case 4:
                    Console.WriteLine("Insert saleId, productId, requiredQuantityForDiscount, isIntendedForAllCustomers, finalPrice, saleStartDate, saleEndDate");
                    int saleId = int.Parse(Console.ReadLine());
                    int productId = int.Parse(Console.ReadLine());
                    int requiredQuantityForDiscount = int.Parse(Console.ReadLine());
                    bool isIntendedForAllCustomers = bool.Parse(Console.ReadLine());
                    int finalPrice = int.Parse(Console.ReadLine());
                    DateTime saleStartDate = DateTime.Parse(Console.ReadLine());
                    DateTime saleEndDate = DateTime.Parse(Console.ReadLine());
                    BO.Sale saleToUpdate = new BO.Sale(saleId, productId, requiredQuantityForDiscount, isIntendedForAllCustomers, finalPrice, saleStartDate, saleEndDate);
                    s_bl.ISale.Update(saleToUpdate);
                    break;
                case 5:
                    Console.WriteLine("Insert saleID");
                    int saleId2 = int.Parse(Console.ReadLine());
                    s_bl.ISale.Delete(saleId2);
                    break;
                default:
                    Console.WriteLine("Invalid choose---😣");
                    break;
            }
        }
    }


    static void Main(string[] args)
    {
        DalTest.Intialization.initialize();
        DisplayMainMenu();
    }
}







