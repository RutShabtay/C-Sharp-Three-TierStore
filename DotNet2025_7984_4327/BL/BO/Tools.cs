using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BO
{
    public static class Tools
    {
        public static DO.Customer CustomerToDo(this BO.Customer boCustomer)
        {
            return new DO.Customer
            {
                customerId = boCustomer.customerId,
                customerName = boCustomer.customerName,
                customerAddress = boCustomer.customerAddress,
                customerPhone = boCustomer.customerPhone,
            };
        }

        public static BO.Customer CustomerToBo(this DO.Customer doCustomer)
        {
            return new BO.Customer
            {
                customerId = doCustomer.customerId,
                customerName = doCustomer.customerName,
                customerAddress = doCustomer.customerAddress,
                customerPhone = doCustomer.customerPhone,
            };
        }

        public static DO.Product ProductToDo(this BO.Product boProduct)
        {
            return new DO.Product
            {
                productId = boProduct.productId,
                productName = boProduct.productName,
                catagory = (DO.Catagories)boProduct.catagory,
                productPrice = boProduct.productPrice,
                quantityInStock = boProduct.quantityInStock,
            };
        }

        public static BO.Product ProductToBo(this DO.Product doProduct)
        {
            return new BO.Product
            {
                productId = doProduct.productId,
                productName = doProduct.productName,
                catagory = (BO.Catagories)doProduct.catagory,
                productPrice = doProduct.productPrice,
                quantityInStock = doProduct.quantityInStock,
            };
        }

        public static DO.Sale SaleToDo(this BO.Sale boSale)
        {
            return new DO.Sale
            {
                saleId = boSale.saleId,
                productId = boSale.productId,
                requiredQuantityForDiscount = boSale.requiredQuantityForDiscount,
                isIntendedForAllCustomers = boSale.isIntendedForAllCustomers,
                finalPrice = boSale.finalPrice,
                saleEndDate = boSale.saleEndDate,
                saleStartDate = boSale.saleStartDate,
            };
        }

        public static BO.Sale SaleToBo(this DO.Sale doSale)
        {
            return new BO.Sale
            {
                saleId = doSale.saleId,
                productId = doSale.productId,
                requiredQuantityForDiscount = doSale.requiredQuantityForDiscount,
                isIntendedForAllCustomers = doSale.isIntendedForAllCustomers,
                finalPrice = doSale.finalPrice,
                saleEndDate = doSale.saleEndDate,
                saleStartDate = doSale.saleStartDate,
            };
        }



        public static string ToStringProperty<T>(this T obj)
        {
            if (obj == null)
                return "null";

            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();
            sb.AppendLine($"{type.Name} properties:");

            foreach (PropertyInfo prop in type.GetProperties())
            {
                object value = prop.GetValue(obj, null);
                if (value is System.Collections.IEnumerable enumerable && !(value is string))
                {
                    sb.AppendLine($"{prop.Name}:");
                    foreach (var item in enumerable)
                    {
                        sb.AppendLine("  - " + item?.ToStringProperty());
                    }
                }
                else
                {
                    sb.AppendLine($"{prop.Name}: {value}");
                }
            }

            return sb.ToString();
        }
    }

}
}
