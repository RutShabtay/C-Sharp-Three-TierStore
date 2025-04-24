using BO;

public class program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get;
/*    DalTest.Initialization.initialize();
*/

    public static void DisplayMainMenue()
    {

        Console.WriteLine("for customer press 1, for principle press 2.");
        int choose = int.Parse(Console.ReadLine());

        while (choose != 1 && choose != 2)
        {
            Console.WriteLine("Invalid choose, Insert again");
            Console.WriteLine("for customer press 1, for principle press 2.");
            choose = int.Parse(Console.ReadLine());
        }
        switch (choose)
        {
            case 1:
                DisplayCustomerMenue();
                break;
            default: displayPrincipleMenue();
                break;
        }
    }

    public static void DisplayCustomerMenue()
    {
        int choose = -1;
        Console.WriteLine("Insert Customer Id---");
        int customerId = int.Parse(Console.ReadLine());
        if (s_bl.Customer.IsExists(customerId))
            Console.WriteLine("Name " + s_bl.Customer.Read(customerId).customerName);
        else
            Console.WriteLine("Name Casual customer😉");
        Order order = new Order();

        while (choose != 6 && choose != 0)
        {
            Console.WriteLine("Back-0, ProductList-1, Add Product to Cart-2, Delete Product-3,View Cart-4, TotalOrderPrice-5, MakeOrder-6 ");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    DisplayMainMenue();
                    break;
                case 1:
                    {
                        List<BO.Product> productList = s_bl.Product.ReadAll();
                        productList.ForEach(product => Console.WriteLine(product));
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Insert productId,quantity");
                        int productId = int.Parse(Console.ReadLine());
                        int quantity = int.Parse(Console.ReadLine());
                        s_bl.Order.AddProductToOrder(order, productId, quantity);

                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Insert productId to delete");
                        int productId = int.Parse(Console.ReadLine());
                        s_bl.Order.AddProductToOrder(order, productId, -1);
                    }
                    break;
                case 4:
                    order.ProductsInOrder.ForEach(product => Console.WriteLine(product));
                    break;
                case 5:
                    Console.WriteLine(order.OrderTotalPrice);
                    break;
                case 6:
                    s_bl.Order.DoOrder(order);
                    break;
                default:
                    Console.WriteLine("Invalid Choose");
                    break;

            }
        }
    }

    public static void displayPrincipleMenue()
    {
        int choose = -1;
        while (choose != 0)
        {
            Console.WriteLine("Back-0, customer-1, products-2, sales-3");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    {
                        DisplayMainMenue();
                    }
                    break;
                defalt: Console.WriteLine("yyyy");
            }
        }

    }









    static void Main(string[] args)
    {

        DisplayMainMenue();
    }

















}




