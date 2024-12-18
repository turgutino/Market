using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Product:Category

    {
        public Guid Id { get; set; }

        public string Product_Name { get; set; }
        public Category category { get; set; }

        public double Price { get; set; }

      

        public Product(){}

        public Product(Guid id,Category category, string product_name,double price)
        {
            Id = id;
            this.category = category;
            Product_Name = product_name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id : {Id}\n{category?.ToString()}\nProduct Name : {Product_Name}\nPrice : {Price:C2}";
        }

    }
}
