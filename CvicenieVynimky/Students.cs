using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CvicenieVynimky
{
    public class Students

       {

        public List<string> InapropriateName { get; set; } = new List<string>{"Fuck","Shit","Idiot"};
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string SchoolClassName { get; set; }
        public string Gender { get; set; }
        public List<int> Grades { get; set; }

        public Students(string name, string surName, int age, string schoolClassName)
        {
            Name = name;
            SurName = surName;
            Age = age;
            SchoolClassName = schoolClassName;
        }

        public Students(string id, string name, string surName, int age, string schoolClassName, string gender)
        {
            var parsed = int.TryParse(id, out int IDResult);
            if (!parsed)
            {
                throw new ArgumentException("Incorrect ID");
            }

            if (name.Length == 0 || surName.Length == 0)
            {
                throw new ArgumentException("Incorrect name or surname");
            }


          
            
               
            foreach (var item in InapropriateName) 
            {
               if (name == InapropriateName[1])
                {
                    throw new ArgumentException("Name contains Inappropriate word");
                }  
            }
            


        }
        public void AddNewGrade(int grade)
        {
            if (grade < 1 || grade > 5)
            {
                throw new ArgumentException("Grade must be between 1 and 5");
            }
            Grades.Add(grade);
        }
    }
}
