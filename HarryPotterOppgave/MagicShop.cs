namespace HarryPotterOppgave
{
    internal class MagicShop
    {
        public string Name { get; private set; }
        public int Money { get; private set; }
        public List<Item> ShopItems { get; private set; }
        public List<Pet> Pets { get; private set; }

        public MagicShop(string name, int money, List<Item> shopItems, List<Pet> pets)
        {
            Name = name;
            Money = money;
            ShopItems = shopItems;
            Pets = pets;
        }
    }
}