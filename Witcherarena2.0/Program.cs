using System.Reflection.Metadata;
using Witcherarena2._0;

Console.WriteLine(@"
 /$$      /$$ /$$   /$$               /$$                                  /$$$$$$                                         
| $$  /$ | $$|__/  | $$              | $$                                 /$$__  $$                                        
| $$ /$$$| $$ /$$ /$$$$$$    /$$$$$$$| $$$$$$$   /$$$$$$   /$$$$$$       | $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$$   /$$$$$$ 
| $$/$$ $$ $$| $$|_  $$_/   /$$_____/| $$__  $$ /$$__  $$ /$$__  $$      | $$$$$$$$ /$$__  $$ /$$__  $$| $$__  $$ |____  $$
| $$$$_  $$$$| $$  | $$    | $$      | $$  \ $$| $$$$$$$$| $$  \__/      | $$__  $$| $$  \__/| $$$$$$$$| $$  \ $$  /$$$$$$$
| $$$/ \  $$$| $$  | $$ /$$| $$      | $$  | $$| $$_____/| $$            | $$  | $$| $$      | $$_____/| $$  | $$ /$$__  $$
| $$/   \  $$| $$  |  $$$$/|  $$$$$$$| $$  | $$|  $$$$$$$| $$            | $$  | $$| $$      |  $$$$$$$| $$  | $$|  $$$$$$$
|__/     \__/|__/   \___/   \_______/|__/  |__/ \_______/|__/            |__/  |__/|__/       \_______/|__/  |__/ \_______/
");
Console.WriteLine("Nacitavam hru......");
Thread.Sleep(2500);
Console.Clear();


Console.WriteLine("Vitaj v hre Witcher arena 2.0!");
List<string> menuOpitions = new List<string>() { "Hrat (H) Opis (O)" };
foreach (string opition in menuOpitions)
{
    Console.WriteLine(opition);
}
string ChoiceMenu = Console.ReadLine();
switch (ChoiceMenu.ToUpper())
{
    case "H":
        Console.WriteLine("Zacinas hru.....");
        Thread.Sleep(1500);
        break;
    case "O":
        Console.Clear();
        Console.WriteLine("Witcher arena je RPG hra v ktorej budes bojovat v jednotlivych arenach proti roznym priseram");
        Console.WriteLine("Tuto hru vytvoril Patrik Smrzo");
        Thread.Sleep(1000);
        Console.WriteLine("Pre navrat do hlavneho menu stlac ENTER..");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Vitaj v hre Witcher Arena!");
        foreach (string option in menuOpitions)
        {
            Console.WriteLine(option);
        }
        ChoiceMenu = Console.ReadLine();
        break;
    default:
        Console.WriteLine("To co si zadal no take tu neni");
        break;
}


string PlayerName = Console.ReadLine();


player Player = new player();
Player.setName(PlayerName);

Console.WriteLine(PlayerName);

