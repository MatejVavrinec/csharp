using System;
using System.Collections.Generic;

class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);



        List<string> listwords = new List<string>();

        listwords.Add("Cau");
        listwords.Add("Miso");
        listwords.Add("ako");
        listwords.Add("bolo");
        listwords.Add("vcera");
        listwords.Add("pocasie");

        int counter = 0;
        foreach (string name in listwords)


        {
            Console.WriteLine(counter++ +name);
        }
        Console.ReadLine();
    }
}





















