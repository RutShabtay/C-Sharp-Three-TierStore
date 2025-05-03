using System.Reflection;
using System.Text;



namespace BO
{
    public static class Tools
    {
        public static DO.Customer CustomerToDo(this BO.Customer boCustomer)
        {
            return new DO.Customer
            {
                CustomerId = boCustomer.CustomerId,
                CustomerName = boCustomer.CustomerName,
                CustomerAddress = boCustomer.CustomerAddress,
                CustomerPhone = boCustomer.CustomerPhone,
            };
        }

        public static BO.Customer CustomerToBo(this DO.Customer doCustomer)
        {
            return new BO.Customer
            {
                CustomerId = doCustomer.CustomerId,
                CustomerName = doCustomer.CustomerName,
                CustomerAddress = doCustomer.CustomerAddress,
                CustomerPhone = doCustomer.CustomerPhone,
            };
        }

        public static DO.Product ProductToDo(this BO.Product boProduct)
        {
            return new DO.Product
            {
                ProductId = boProduct.ProductId,
                ProductName = boProduct.ProductName,
                Catagory = (DO.Catagories)boProduct.Catagory,
                ProductPrice = boProduct.ProductPrice,
                QuantityInStock = boProduct.QuantityInStock,
            };
        }

        public static BO.Product ProductToBo(this DO.Product doProduct)
        {
            return new BO.Product
            {
                ProductId = doProduct.ProductId,
                ProductName = doProduct.ProductName,
                Catagory = (BO.Catagories) doProduct.Catagory,
                SaleInProducts = new List<BO.SaleInProduct>(),
                ProductPrice = doProduct.ProductPrice,
                QuantityInStock = doProduct.QuantityInStock
            };
        }

        public static DO.Sale SaleToDo(this BO.Sale boSale)
        {
            return new DO.Sale
            {
                SaleId = boSale.SaleId,
                SaleProductId = boSale.SaleProductId,
                RequiredQuantityForDiscount = boSale.RequiredQuantityForDiscount,
                IsIntendedForAllCustomers = boSale.IsIntendedForAllCustomers,
                FinalPrice = boSale.FinalPrice,
                SaleEndDate = boSale.SaleEndDate,
                SaleStartDate = boSale.SaleStartDate,
            };
        }

        public static BO.Sale SaleToBo(this DO.Sale doSale)
        {
            return new BO.Sale
            {
                SaleId = doSale.SaleId,
                SaleProductId = doSale.SaleProductId,
                RequiredQuantityForDiscount = doSale.RequiredQuantityForDiscount,
                IsIntendedForAllCustomers = doSale.IsIntendedForAllCustomers,
                FinalPrice = doSale.FinalPrice,
                SaleEndDate = doSale.SaleEndDate,
                SaleStartDate = doSale.SaleStartDate,
            };
        }

        public static SaleInProduct saleToSaleInProduct(this DO.Sale sale)
        {
            return new SaleInProduct
            {
                SaleId = sale.SaleId,
                QuantityForSale = sale.RequiredQuantityForDiscount,
                Price = sale.FinalPrice,
                IsIntendedForAllCustomers = sale.IsIntendedForAllCustomers,
            };
        }


        public static string ToStringProperty<T>(this T obj, int indentLevel = 0)
        {
            if (obj == null)
                return "null";

            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();
            string indent = new string(' ', indentLevel * 2);

            foreach (PropertyInfo prop in type.GetProperties())
            {
                object value = prop.GetValue(obj, null);

                if (value is System.Collections.IEnumerable enumerable && !(value is string))
                {
                    sb.AppendLine($"{indent} {prop.Name}:");
                    foreach (var item in enumerable)
                    {
                        if (item == null)
                        {
                            sb.AppendLine($"{indent}   null");
                        }
                        else
                        {
                            string itemString = item.ToStringProperty(indentLevel + 2).TrimEnd();
                            sb.AppendLine($"{indent} -  {itemString.Replace("\n", "\n" + indent + "    ")}");
                        }
                    }
                }
                else
                {
                    sb.AppendLine($"{indent} {prop.Name}: {value}");
                }
            }

            return sb.ToString();
        }

    }
}

