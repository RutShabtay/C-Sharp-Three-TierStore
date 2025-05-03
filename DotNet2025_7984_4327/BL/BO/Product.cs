using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Catagories Catagory { get; set; }
        public double ProductPrice { get; set; }
        public int QuantityInStock { get; set; }
        public List<SaleInProduct>? SaleInProducts { get; set; }

        public override string ToString() => this.ToStringProperty();
        public Product() { }
        public Product(int productId, string productName, Catagories catagory, double productPrice, int quantityInStock, List<SaleInProduct>? saleInProducts)
        {
            ProductId = productId;
            ProductName = productName;
            Catagory = catagory;
            ProductPrice = productPrice;
            QuantityInStock = quantityInStock;
            SaleInProducts = saleInProducts;
        }
    }
}
