using DataBase.Classes;

namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category1=new Category(Guid.NewGuid(),"Et Mehsullari");
            Product product1=new Product(Guid.NewGuid(),category1,"Kolbasa",12);
            Item item1= new Item(Guid.NewGuid(),product1,32);
            Category category2 = new Category(Guid.NewGuid(), "Sud mehsullari");
            Product product2 = new Product(Guid.NewGuid(), category2, "Pendir", 4);
            Item item2 = new Item(Guid.NewGuid(),product2, 50);
            item1.Add_Product();
            item1.Get_All();
            item2.Add_Product();
            item2.Get_All();
            Console.WriteLine("Update : ");
            item1.Update_Product();
            item2.Update_Product();
            Console.WriteLine("Update successfully");
        }
    }
}
