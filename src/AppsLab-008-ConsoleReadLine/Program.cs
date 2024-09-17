/*Skusanie ConsoleReadLine 

Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno + "\n");

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");
Console.WriteLine("");

Console.WriteLine("Ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine($"Hmmm, " + jedlo + " znie skvele!");


Console.WriteLine("Volam sa " + meno + ", je mi " + vek + " a moje oblubene jedlo je " + jedlo + "!");*/

int prveCislo = 55;
int druheCislo = 80;

Console.WriteLine(prveCislo + druheCislo);

int tretieCislo = 100;
int stvrteCislo = 75;

Console.WriteLine(tretieCislo - stvrteCislo);

int piateCislo = 5;
int siesteCislo = 4;
 
Console.WriteLine(piateCislo * siesteCislo);

int siedmeCislo = 50;
int osmeCislo = 10;

Console.WriteLine(siedmeCislo / osmeCislo);

int deviateCislo = 10;
int desiateCislo = 4;

Console.WriteLine(deviateCislo % desiateCislo);





Console.WriteLine(55 == 80);
Console.WriteLine(80 == 80);

Console.WriteLine(55 != 80);
Console.WriteLine(80 != 80);

Console.WriteLine(23 > 15);
Console.WriteLine(18 > 23);

Console.WriteLine(18 < 23);
Console.WriteLine(23 < 18);

Console.WriteLine(3 >= 2);
Console.WriteLine(3 >= 5);

Console.WriteLine(3 <= 3);
Console.WriteLine(3 <= 1);





//Z databazy
var menoUzivatela = "Matej";
var hesloUzivatela = "1234567";

//Zadane uzivatelom
var zadaneMeno = "Matej";
var zadaneHeslo = "1234567";


var porovnavanieMena = menoUzivatela == zadaneMeno;
var porovnavanieHesiel = hesloUzivatela == zadaneHeslo;

var prijatPristup = porovnavanieMena && porovnavanieHesiel;

if (prijatPristup)
{
    Console.WriteLine("Heslo sa zhoduje, vitaj " + menoUzivatela == zadaneMeno);
}
else
{
    Console.WriteLine("Heslo sa NEZHODUJE");
}
