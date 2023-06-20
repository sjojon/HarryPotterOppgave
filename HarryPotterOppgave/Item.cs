namespace HarryPotterOppgave
{
    internal class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public int Price { get; private set; }


        public Item(string name, string description, int quantity, int price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        public void ItemDescription()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nQuantity: {Quantity}");
        }
    }
}