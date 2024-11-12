namespace Cvicenie_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<Student> students = new List<Student>()
            {
                new Student { Name = "Anna Maria", Age = 20 },
                new Student { Name = "Anna Hruskova", Age = 40 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 18 }
            };

            var tinedzeriStudenti_Straysposob = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Name.Contains("Anna"))
                {
                    tinedzeriStudenti_Straysposob.Add(student);
                }
            } 
            
            var tinedzeriStudenti = students.Where(student => student.Name.Contains("Anna")).ToList();
            foreach (Student student in tinedzeriStudenti)
            {
                Console.WriteLine($"LINQ:Student, {student.Name} ma {student.Age} a je tinedzer");
            }
            */


            List<Kniha> knihy = new List<Kniha>()
            {
             new Kniha { Autor = "Rowlingova3", RokVydania = 1997, JepreDospelych = false },
             new Kniha { Autor = "Rowlingova2", RokVydania = 1997, JepreDospelych = false },
             new Kniha { Autor = "Rowlingova", RokVydania = 1997, JepreDospelych = false },
            new Kniha { Autor = "Tolkien", RokVydania = 1937, JepreDospelych = false },
            new Kniha { Autor = "Tolkien", RokVydania = 1954, JepreDospelych = true },
            new Kniha { Autor = "Andrzej", RokVydania = 2017, JepreDospelych = true },
            new Kniha { Autor = "Keith", RokVydania = 2013, JepreDospelych = false },
            };
            Kniha prcaknihaOld = knihy[0];
            Kniha prvakniha = knihy.First();

            List<Kniha> knihypremladez = knihy.Where(kniha => !kniha.JepreDospelych).ToList();
            List<Kniha> knihyOdNajstarsej = knihy.OrderBy(kniha => kniha.RokVydania).ToList();
            List<Kniha> knihyOdNajnovsej = knihy.OrderByDescending(kniha => kniha.RokVydania).ToList();
            List<Kniha> knihyPreMladezOdNajstarsej = knihy.Where(kniha => !kniha.JepreDospelych).OrderBy(kniha => kniha.RokVydania).ToList();

            var knihyByYear = knihy.GroupBy(u => u.RokVydania).Select(grp => grp.ToList()).ToList();

           /* foreach (Kniha kniha in knihyOdNajstarsej)
            {
                Console.WriteLine($"LINQ: Kniha od autorky {kniha.Autor} vydana v roku {kniha.RokVydania} je dostupna aj pre mladez");
                              

            }*/

            foreach (List<Kniha>skupinka in knihyByYear)
            {
                Console.WriteLine($"Skupinka:");
                foreach (Kniha kniha in skupinka)
                {
                    Console.WriteLine($" {kniha.Autor.ToUpper()}{kniha.RokVydania}");
                }
            }
            Console.WriteLine();
            var knihyByYear_IDictionary = knihy.GroupBy(o => o.RokVydania).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var skupinka in knihyByYear_IDictionary)
            {
                Console.WriteLine($"Skupinka {skupinka.Key}:");
                foreach (Kniha kniha in skupinka.Value)
                {
                    Console.WriteLine($"{kniha.Autor.ToUpper()} {kniha.RokVydania}");
                }
            }

            
            
        }
    }
}