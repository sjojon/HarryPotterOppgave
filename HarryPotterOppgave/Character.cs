namespace HarryPotterOppgave
{
    internal class Character
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public House House { get; private set; }
        public int Money { get; private set; }
        public List<Item> PersonalItems { get; private set; }
        public List<Spell> Spells { get; private set; }


        public Character(string firstName, string lastName, House house, int money, List<Item> personalItems,
            List<Spell> spells)
        {
            FirstName = firstName;
            LastName = lastName;
            House = house;
            Money = money;
            PersonalItems = personalItems;
            Spells = spells;
        }

        public void DisplayCharacter() // Character character
        {
            Console.WriteLine("Character info:");
            Console.WriteLine();
            Console.WriteLine($"Name: {FirstName} {LastName}\nHouse: {House.Name}\nGold coins: {Money}");
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

        public void ListOfSpells()
        {
            Console.WriteLine("Current known spells:");
            Console.WriteLine();
            foreach (var spell in Spells)
            {
                spell.PrintSpellDescription();
                Console.WriteLine();
            }
        }
    }
}