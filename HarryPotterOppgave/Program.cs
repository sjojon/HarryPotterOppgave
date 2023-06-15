/*
 Oppgave: 

Harry Potter oppgave!

Du skal starte med å lage en harrypotter character klasse med egenskaper som er unike for hvordan de kan beskrives, 
eller hva de kan eie eller hva de kan gjøre.

Eksempler er: 
House: huffelpuff, griffindor, slytherin, ravenclaw
Items: wand, owl, etc

Få applikasjonen til å printe ut en introduksjon for charakteren, som sier noe om hva de heter, 
hvilket hus de er medlem av og hvilke items de har

Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle,rotte eller en katt. 
De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. 
For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, 
og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen

trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier)



Dersom en karakter har en ugle, har de mulighet til å sende et brev med uglen til en annen karakter. 
Karakteren som mottar brevet, får da brevet i inventoryen. Et brev inneholder en melding.
 */

using HarryPotterOppgave;

Character tim = new("Tim", "Timber", "Hufflepuff", 50, new List<Item>()
{
    new("Compass", "Old, rusty compass that belonged to grandfather", 1),
    new("Wand", "Plain oak wand", 1),
    new("Glasses", "Normal round glasses", 1),
    new("Magical beans", "Beans that grow in one night", 5)
});

//Item wand = new("Wand", "Plain oak wand", 1);
//Item glasses = new("Glasses", "Normal round glasses", 1);
//Item magicalBeans = new("Magical beans", "Beans that grow in one night", 5);
//tim.AddItem(wand);
//tim.AddItem(glasses);
//tim.AddItem(magicalBeans);
tim.DisplayCharacter();
tim.InventoryItems();
Menu();

void Menu()
{
    bool flag = true;
    while (flag)
    {
        Console.WriteLine("Welcome to Hogwarts!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine(
            "1. Create Character\n2. Edit Character\n3. Enter Magic shop\n4. Send letter (Must own owl)\n5. Exit");
        int answer = int.Parse(Console.ReadLine());
        switch (answer)
        {
            case 1:

                break;
            case 2:

                break;
            case 5:
                flag = false;
                break;
        }
    }
}