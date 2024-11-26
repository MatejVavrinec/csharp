using System.Linq.Expressions;

namespace CvicenieVynimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nacitavanie so subora Studenti.Csv

            var data = File.ReadAllLines("studenti_large_chyba.csv");

            var students = new List<Students>();
           
            foreach (var row in data.Skip(1))
            {

                var splits = row.Split(',');
                try
                {
                    var newStudent = new Students(splits[0], splits[1], splits[2], Int32.Parse(splits[3]), "I.AI", splits[4]);
                    students.Add(newStudent);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Chyba pri nacitani studensta:" + row);

                    //Priklad na vynimku pri deleni nulou a nespravnym indexom
                    /*
                                    try
                                    {
                                        int[] deviders = { 0, 2, 3 };
                                        int value = deviders[1];
                                        int result = 5 / value;
                                        Console.WriteLine(result);
                                    }
                                    catch (IndexOutOfRangeException ex)
                                    {
                                        Console.WriteLine("Chyba: Pristup mimo dosah pola.");
                                    }
                                    catch (DivideByZeroException ex)
                                    {
                                        Console.WriteLine("Chyba: Delenie nulou neni povolene");
                                    }
                    */
                }



                //Priklad na vznimky pri nespravnom nacitanom subore
                /*
                foreach (var row in data.Skip(1))
                {
                    var splits = row.Split(',');
                    try
                    {
                        var newStudent = new Students(splits[0], splits[1], splits[2], Int32.Parse(splits[3]), "I.AI", splits[4]);
                        students.Add(newStudent);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Chyba pri nacitani studensta:" + row);
                    }*/
               
                
                
               /* 
                Students[] student = new Students[]
                {
                  new Students("John", "Doe", 20, "Class A"){ Grades = new List<int>(){1,2,3,4,4,2,1}},
                  new Students("Jane", "Smith", 22, "Class B"),
                  new Students("Sam", "Brown", 19, "Class C")
                };
                var firstStudent = student[0];
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Zadajte znamku studentovi:");
                        int znamka = Int32.Parse(Console.ReadLine());
                        firstStudent.AddNewGrade(znamka);
                        Console.WriteLine(firstStudent.Grades.Average());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }*/
                }

            }


        }
    }
