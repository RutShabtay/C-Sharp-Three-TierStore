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
        public int productId { get; init; }
        public string productName { get; set; }
        public Catagories catagory { get; set; }
        public double productPrice { get; set; }
        public int quantityInStock { get; set; }
        public List<SaleInProduct>? saleInProducts { get; set; }

        public override string ToString() => this.ToStringProperty();
        public Product() { }
        public Product(int productId, string productName, Catagories catagory, double productPrice, int quantityInStock, List<SaleInProduct>? saleInProducts)
        {
            this.productId = productId;
            this.productName = productName;
            this.catagory = catagory;
            this.productPrice = productPrice;
            this.quantityInStock = quantityInStock;
            this.saleInProducts = saleInProducts;
        }
    }
}
