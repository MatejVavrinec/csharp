//Skusanie ConsoleReadLine 

Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

Console.WriteLine("Ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Mas rad " + jedlo);

