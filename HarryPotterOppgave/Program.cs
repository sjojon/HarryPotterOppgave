/*
 Oppgave: 

Harry Potter oppgave!

Du skal starte med å lage en harry potter character klasse med egenskaper som er unike for hvordan de kan beskrives, 
eller hva de kan eie eller hva de kan gjøre.

Eksempler er: 
House: huffelpuff, griffindor, slytherin, ravenclaw
Items: wand, owl, etc

Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, 
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
Karakteren som mottar brevet, får da brevet i inventory. Et brev inneholder en melding.
 */

using HarryPotterOppgave;

List<Character> characters = new();

Character tim = new("Tim", "Timber", new House("Hufflepuff", "House of Hufflepuff"), 200,
    new List<Item>()
    {
        new("Compass", "Old, rusty compass that belonged to grandfather", 1, 25),
        new("Glasses", "Normal round glasses", 1, 150),
        new("Magical beans", "Beans that grow in one night", 5, 15),
        new("Oak Wand", "Plain wand made from Oak", 1, 40)
    },
    new List<Spell>()
    {
        new("Vingardium leviosa", "Make things levitate"),
        new("Hokus pokus", "Lights up fireworks"),
        new("Luminos", "Lights up wand like a flashlight")
    },
    new List<Pet>()
    {
    });

characters.Add(tim);

MagicShop magicShop = new("The Black Toad", 5000,
    new List<Item>()
    {
        new("Phoenix Wand", "Wand made from the ashes of a Phoenix", 1, 200),
        new("Unicorn Wand", "Wand made from the horn of a unicorn", 1, 150),
        new("Troll Wand", "Wand made from the bones of a troll", 1, 75)
    },
    new List<Pet>()
    {
        new("Herbert", "Send Letter", "Owl", 75),
        new("Ratty", "Scouting in tight spaces", "Rat", 25),
        new("Kitty", "Dark vision", "Cat", 50)
    });

//tim.DisplayCharacter();
//tim.InventoryItems();
//tim.ListOfSpells();  // TODO: Slå på disse for testing av Tim.
//tim.ListOfPets();
Menu();

void Menu()
{
    bool flag = true;
    while (flag)
    {
        Console.Clear(); // TODO: Slå av denne for testing av Tim.
        Console.WriteLine("Welcome to Hogwarts!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine(
            "1. Character editing\n2. Do magic\n3. Enter magic shop\n4. Send letter (Must own owl)\n5. Exit");
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
    string house = "";
    string houseDescription = "";
    Console.Clear();
    Console.WriteLine("Create a new wizard:");
    Console.WriteLine("First name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Last name");
    string lastName = Console.ReadLine();

    Console.WriteLine("Choose your House:\n1. Hufflepuff\n2. Griffindor\n3. Ravenclaw\n4. Slytherin");
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            house = "Hufflepuff";
            houseDescription = "House of Hufflepuff";
            break;
        case 2:
            house = "Griffindor";
            houseDescription = "House of Griffindor";
            break;
        case 3:
            house = "Ravenclaw";
            houseDescription = "House of Ravenclaw";
            break;
        case 4:
            house = "Slytherin";
            houseDescription = "House of Slytherin";
            break;
    } // TODO: Må legge til så denne looper hvis det blir skrevet feil


    Character character = new(firstName, lastName, new House(house, houseDescription), 200, new List<Item>(),
        new List<Spell>(), new List<Pet>());
    characters.Add(character);
    character.DisplayCharacter();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    CharacterControl();
}


void EditCharacter()
{
    Console.Clear();
    Console.WriteLine("Who do you want to edit?");
    Console.WriteLine();
    foreach (var character in characters)
    {
        Console.WriteLine($"ID: {character.Id}\nName: {character.FirstName} {character.LastName}");
    }

    Console.WriteLine("Enter the ID of the character you want to edit");
    int input = int.Parse(Console.ReadLine());
    bool idFound = false;
    foreach (var character in characters)
    {
        if (character.Id == input)
        {
            EditMenu(character);
            idFound = true;
            break;
        }
    }

    if (!idFound)
    {
        Console.WriteLine("Please enter correct number! Press any key to continue");
        Console.ReadKey();
        EditCharacter();
    }
}

void EditMenu(Character character)
{
    Console.Clear();
    character.DisplayCharacter();
    character.InventoryItems();
    character.ListOfSpells();
    character.ListOfPets();
    Console.WriteLine("What do you want to edit?");
    Console.WriteLine(
        "1. First Name\n2. Last Name\n3. House\n4. Money\n5. Items\n6. Spells\n7. Pets\n8. Back to edit menu");
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            EditFirstName(character);
            break;
        case 2:
            EditLastName(character);
            break;
        case 3:
            EditHouse(character);
            break;
        case 4:
            EditMoney(character);
            break;
        case 5:
            EditItems(character);
            break;
        case 6:
            EditSpells(character);
            break;
        case 7:
            EditPets(character);
            break;
        case 8:
            CharacterControl();
            break;
    }
}

void EditFirstName(Character character)
{
    Console.Clear();
    Console.WriteLine("Enter new firstname:");
    string newFirstName = Console.ReadLine();
    character.UpdateFirstName(newFirstName);
    Console.Clear();
    //character.DisplayCharacter();
    Console.WriteLine("Firstname updated, press any key to return to the character edit menu.");
    Console.ReadKey();
    EditMenu(character);
}

void EditLastName(Character character)
{
    Console.Clear();
    Console.WriteLine("Enter new lastname:");
    string newLastName = Console.ReadLine();
    character.UpdateLastName(newLastName);
    Console.Clear();
    //character.DisplayCharacter();
    Console.WriteLine("Lastname updated, press any key to return to the character edit menu.");
    Console.ReadKey();
    EditMenu(character);
}

void EditHouse(Character character)
{
    Console.Clear();
    Console.WriteLine("Choose your House:\n1. Hufflepuff\n2. Griffindor\n3. Ravenclaw\n4. Slytherin");
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            character.UpdateHouse("Hufflepuff", "House of Hufflepuff");
            break;
        case 2:
            character.UpdateHouse("Griffindor", "House of Griffindor");
            break;
        case 3:
            character.UpdateHouse("Ravenclaw", "House of Ravenclaw");
            break;
        case 4:
            character.UpdateHouse("Slytherin", "House of Slytherin");
            break;
    }

    Console.Clear();
    character.DisplayCharacter();
    Console.WriteLine("House updated, press any key to return to the character edit menu.");
    Console.ReadKey();
    EditMenu(character);
}

void EditMoney(Character character)
{
    Console.Clear();
    Console.WriteLine("Enter new amount of money:");
    int newMoney = int.Parse(Console.ReadLine());
    character.UpdateMoney(newMoney);
    Console.Clear();
    character.DisplayCharacter();
    Console.WriteLine("Money updated, press any key to return to the character edit menu.");
    Console.ReadKey();
    EditMenu(character);
}

void EditItems(Character character)
{
    throw new NotImplementedException();
}

void EditSpells(Character character)
{
    throw new NotImplementedException();
}

void EditPets(Character character)
{
    throw new NotImplementedException();
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