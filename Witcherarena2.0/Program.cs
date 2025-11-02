using System.Reflection.Metadata;
using Witcherarena2._0;

Console.WriteLine("Pre lepsi zazitok z hry daj si okno konzoly na celu obrazovku!");
Thread.Sleep(1000);
Console.WriteLine("Pre pokracovanie stlac ENTER...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Loading game");

int i = 0;
while (i < 5)
{
    Thread.Sleep(150);
    Console.Clear();
    Console.WriteLine(".");
    Thread.Sleep(150);
    Console.Clear();
    Console.WriteLine("..");
    Thread.Sleep(150);
    Console.Clear();
    Console.WriteLine("...");
    Thread.Sleep(150);
    Console.Clear();
    i++;
}

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
Console.WriteLine("Vitaj!!");
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


Console.WriteLine("Pre HIT stlac 'H'..");
Console.ReadLine();
monster1.TakeDamage();
Console.WriteLine("Prisera sa brani!");
Player.TakeDamage();
Console.WriteLine(stats);
Console.WriteLine(monsterStats);
Console.WriteLine("Pre HIT stlac 'H'..");
Console.ReadLine();
monster1.TakeDamage();
Console.WriteLine("Ziskal si schopnost pre rychly utok!");
monster1.TakeKill();
Console.WriteLine("Prisera je mrtva!");
Thread.Sleep(1000);
Console.WriteLine("Zostatok zivotov nepriatela : 0");
Console.WriteLine("Pre pokracovanie stlac ENTER..");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Gratulujem prezil si prvu arenu!");
Thread.Sleep(300);
Console.WriteLine("Wait.....");
Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("Vytaj v druhej arene");
Thread.Sleep(500);
Console.WriteLine(player.Stats());
Console.WriteLine("Pre vstup do areny stlac ENTER....");
Console.ReadLine();
Console.Clear();



player Player1 = new player();
_2monster2 monster2 = new _2monster2();
string statsM = monster2.currentMonster2Stats(monster2);

Console.WriteLine("Prisera sa zobudza!");
Thread.Sleep(1000);
Console.WriteLine("Pre HIT stlac 'H'");
Console.ReadLine();
monster2.TakeDamage();
Console.WriteLine("Davaj si pozor prisera utoci!");
Thread.Sleep(1000);
Console.WriteLine("Pre hit Stlac 'H'");
Console.ReadLine();
monster2.TakeDamage(20);
Console.WriteLine(statsM);
Thread.Sleep(1500);
Console.Clear();
Console.WriteLine("Znova stlac 'H'");
Console.ReadLine();
monster2.TakeDamage(20);
Console.WriteLine("Zostatok zivotov nepriatela : 60");
Thread.Sleep(1500);
Console.Clear();
Console.WriteLine("Pre posledny silny hit stlac 2x  'H'");
Console.ReadLine();
monster2.TakeDamage(20);
Console.WriteLine("Prisera je mrtva!");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Gratulujem prezil si druhu arenu!");
Thread.Sleep(3000);
Console.Clear();


Console.WriteLine("Tvoje skore je 2000 bodov!");
Thread.Sleep(1500);
Console.WriteLine("Gratulujem!");
Thread.Sleep(500);
Console.WriteLine("Wait.....");
Thread.Sleep(3000);
Console.WriteLine("Koniec hry!");
Console.WriteLine("Pre ukoncenie stlac ENTER..");
Console.ReadLine();
Console.Clear();
