using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.InterFaces;
namespace DataBase.Classes
{
    public class Item:IItems
    {
        public Guid Id2 { get; set; }
        public Product Product { get; set; }

        public int Count { get; set; }

        public List<Product> Items { get; set; } = new List<Product>();

        public Item() { }

        public Item(Guid id,Product product, int count)
        {
            Id2= id;
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            var result = $"Id : {Id2}\nProduct : {Product?.ToString()}\nCount : {Count}\nItems :\n";
            foreach (var item in Items)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }
        public void Add_Product()
        {
            Items.Add(Product);
        }
        public void Delete_Product()
        {
            Items.Remove(Product);
        }

        public void Update_Product()
        {
            
            string name;
            Console.Write("Enter product name : ");
            name = Console.ReadLine();
            bool check = false;
            foreach (var item in Items) {
                if (item.Product_Name == name)
                {
                    string new_name;
                    Console.Write("Enter new product name : ");
                    new_name = Console.ReadLine();
                    item.Product_Name = name;
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("This name cannot found");
            }
            
        }

        public void Get_All()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
