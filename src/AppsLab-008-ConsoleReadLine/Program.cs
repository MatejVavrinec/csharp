//Skusanie ConsoleReadLine 

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


Console.WriteLine("Volam sa " + meno + ", je mi " + vek + " a moje oblubene jedlo je " + jedlo + "!");
 
