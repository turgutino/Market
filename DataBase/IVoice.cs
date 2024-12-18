using DataBase.Classes;


namespace DataBase

{
    public class IVoice
    {
        public Guid Id { get; set; }

        public List<Item> items = new List<Item>();

        public double Total_Price { get; set; }

        public IVoice(){}

        public IVoice(Guid id, List<Item> items, double total_Price)
        {
            Id = id;
            this.items = items;
            Total_Price = total_Price;
        }


        public void Add_Card()
        {
            items.Add(new Item());
        }

        public void Buy_Card()
        {
            Console.WriteLine("Successfully");
        }
    }
}
