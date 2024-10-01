using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];


            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;


            Console.WriteLine(numbers[2] + numbers[3]);


            List<string> listwords = new List<string>();

            listwords.Add("Cau");
            listwords.Add("Miso");
            listwords.Add("ako");
            listwords.Add("bolo");
            listwords.Add("vcera");
            listwords.Add("vecer"); 
            Console.WriteLine(listwords[0]);
            Console.WriteLine(listwords[1]);
            Console.WriteLine(listwords[2]);
            Console.WriteLine(listwords[3]);
            Console.WriteLine(listwords[4]);
            Console.WriteLine(listwords[5]);









            Console.ReadLine();















        }
    }
}
