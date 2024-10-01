using System;
using System.Collections.Generic;

internal static class ProgramHelpers
{


    static void Main(string[] args)
    {

        List<string> listwords = new List<string>();

        listwords.Add("Cau");
        listwords.Add("Miso");
        listwords.Add("ako");
        listwords.Add("bolo");
        listwords.Add("vcera");
        listwords.Add("pocasie");

        int counter = 6;
        foreach (string name in listwords)
        {
            Console.WriteLine(name);
        }
    }
}


       