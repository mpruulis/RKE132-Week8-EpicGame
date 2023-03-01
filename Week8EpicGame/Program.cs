string folderPath = @"C:\Users\Lenovo\source\repos\Week8EpicGame";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] pahad = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Martin Helme", "Mart Helme", "Varro Vooglaid", "Jumal" };
//string[] pahad = { "Kaja Kallas", "Siim Kallas", "Jürgen Ligi", "Urmas Kruuse" };

string[] weapon = { "Süütamine", "Valetamine", "Sundimine", "Vabaduse piiramine", "Aktsiiside langetamine", "energia norm hind" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Täna päästab Eesti {hero} kasutades {heroWeapon}!");

string paha = GetRandomValueFromArray(pahad);
string pahaWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Täna hävitab Eesti {paha} kasutades selleks {pahaWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next (0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}