using System.Xml.Linq;

namespace HarryPotterOppgave
{
    internal class Spell
    {
        public string SpellName { get; private set; }
        public string SpellDescription { get; private set; }

        public Spell(string spellName, string spellDescription)
        {
            SpellName = spellName;
            SpellDescription = spellDescription;
        }

        public void PrintSpellDescription()
        {
            Console.WriteLine($"Name: {SpellName}\nDescription: {SpellDescription}");
        }
    }
}