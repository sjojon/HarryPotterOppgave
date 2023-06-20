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

Character tim = new("Tim", "Timber", new House("Hufflepuff", "House of Hufflepuff"), 200,
    new List<Item>()
    {
        new("Compass", "Old, rusty compass that belonged to grandfather", 1, 25),
        new("Oak Wand", "Plain oak wand", 1, 40),
        new("Glasses", "Normal round glasses", 1, 150),
        new("Magical beans", "Beans that grow in one night", 5, 15)
    },
    new List<Spell>()
    {
        new("Vingardium leviosa", "Make things levitate"),
        new("Hokus pokus", "Lights up fireworks"),
        new("Luminos", "Lights up wand like a flashlight"),
    },
    new List<Pet>()
    {
    });

MagicShop magicShop = new("The Black Toad", 5000,
    new List<Item>()
    {
        new("Phoenix Wand", "Wand made from the ashes of a Phoenix", 4, 200),
        new("Unicorn Wand", "Wand made from the horn of a unicorn", 2, 150),
        new("Troll Wand", "Wand made from the bones of a troll", 6, 75),
    },
    new List<Pet>()
    {
        new("Herbert", "Send Letter", "Owl", 75),
        new("Ratty", "Scouting in tight spaces", "Rat", 25),
        new("Kitty", "Dark vision", "Cat", 50),
    });

//Item wand = new("Wand", "Plain oak wand", 1);
//Item glasses = new("Glasses", "Normal round glasses", 1);
//Item magicalBeans = new("Magical beans", "Beans that grow in one night", 5);
//tim.AddItem(wand);
//tim.AddItem(glasses);
//tim.AddItem(magicalBeans);
tim.DisplayCharacter();
tim.InventoryItems();
tim.ListOfSpells();
tim.ListOfPets();
Menu();

void Menu()
{
    bool flag = true;
    while (flag)
    {
        //Console.Clear(); // TODO: Slå av denne for testing av Tim.
        Console.WriteLine("Welcome to Hogwarts!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine(
            "1. Character editing\n2. Do magic\n3. Enter Magic shop\n4. Send letter (Must own owl)\n5. Exit");
        int answer = int.Parse(Console.ReadLine());
        switch (answer)
        {
            case 1:
                CharacterControl();
                break;
            case 2:
                DoMagic();
                break;
            case 3:
                MagicShopMenu();
                break;
            case 4:
                SendLetter();
                break;
            case 5:
                flag = false;
                break;
        }
    }
}

void CharacterControl()
{
    Console.Clear();
    Console.WriteLine("This is the Character creation and editing screen:");
    Console.WriteLine("1. Create character\n2. Edit character\n3. Main menu");
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            CreateCharacter();
            break;
        case 2:
            EditCharacter();
            break;
        case 3:
            Menu();
            break;
    }
}

void CreateCharacter()
{
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            CharacterControl();
            break;
    }
}

void EditCharacter()
{
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            CharacterControl();
            break;
    }
}

void DoMagic()
{
}

void MagicShopMenu()
{
    Console.Clear();
    Console.WriteLine($"Welcome to {magicShop.Name} magic shop!");
    Console.WriteLine("What can we do for you today?");
    Console.WriteLine("1. Buy pet\n2. Buy wand\n3. Main menu");
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            Menu();
            break;
    }
}

void SendLetter()
{
}