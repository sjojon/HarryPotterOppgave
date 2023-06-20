namespace HarryPotterOppgave
{
    internal class Pet
    {
        public string PetName { get; private set; }
        public string Ability { get; private set; }
        public string Type { get; private set; }
        public int Price { get; private set; }

        public Pet(string petName, string ability, string type, int price)
        {
            PetName = petName;
            Ability = ability;
            Type = type;
            Price = price;
        }

        public void PetDetails()
        {
            Console.WriteLine($"Name: {PetName}\nAbility: {Ability}\nType of animal: {Type}");
        }
    }
}