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
        Console.Clear();
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
        return;
}
player Player = new player();
Console.WriteLine("Zadaj meno svojho hraca:");
string PlayerName = Console.ReadLine();
Player.setName(PlayerName);

Console.WriteLine($"Meno hraca je {PlayerName}");
Thread.Sleep(1000);
Console.WriteLine("Pre nacitanie prvej areny stlac ENTER..");
Console.ReadLine();
Console.Clear();    


Console.WriteLine("Vitaj v prvej arene");
Thread.Sleep(1000);
Player.startStats();
string Stats = Player.startStats();
Console.WriteLine(Stats);
Thread.Sleep(1000);
Console.WriteLine("Pre zacatie boja stlac ENTER...");
Console.ReadLine();
Console.Clear();


player player = new player();
_1Monster1 monster1 = new _1Monster1();
string stats = Player.Stats();
string monsterStats = monster1.currentMonsterStats(monster1);

Console.WriteLine("Prisera sa zobudza pre HIT stac 'H'..");
Console.ReadLine();
monster1.TakeDamage();
Player.TakeDamage();
Console.WriteLine($"Davaj si pozor prisera utoci!");
Thread.Sleep(500);
Console.WriteLine(stats);
Console.WriteLine(monsterStats);







