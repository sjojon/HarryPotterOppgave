namespace HarryPotterOppgave
{
    internal class House
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public House(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}