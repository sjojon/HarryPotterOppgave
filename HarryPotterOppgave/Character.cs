namespace HarryPotterOppgave
{
    internal class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public int Money { get; private set; }
        public List<Item> PersonalItems { get; private set; }


        public Character(string name, string house, int money, List<Item> personalItems)
        {
            Name = name;
            House = house;
            Money = money;
            PersonalItems = personalItems;
        }

        public void DisplayCharacter() // Character character
        {
            Console.WriteLine("Character info:");
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}\nHouse: {House}\nGold coins: {Money}");
            Console.WriteLine();
        }

        public void AddItem(Item item)
        {
            PersonalItems.Add(item);
        }

        public void RemoveItem(Item item)
        {
            PersonalItems.Remove(item);
        }

        public void InventoryItems()
        {
            Console.WriteLine("Inventory:");
            Console.WriteLine();
            foreach (var item in PersonalItems)
            {
                item.ItemDescription();
                Console.WriteLine();
            }
        }
    }
}