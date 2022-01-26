using System;
using System.Linq.Expressions;
using ConsoleAppCSharp9.Models;

namespace ConsoleAppCSharp9
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Example1");
            Example1();
            Console.WriteLine("--------");
            Console.WriteLine("Example4");
            Example4();
            Console.WriteLine("--------");
            Console.WriteLine("Example6");
            Example6();
            Console.WriteLine("--------");
        }

        private static void Example1()
        {
            var rp1 = new RecordPerson("ilkay", "kabas");
            var rp2 = new RecordPerson("ilkay", "kabas");
            Console.WriteLine(rp1.Equals(rp2));

            var rp3 = rp1 with {FirstName = "abc"};
            Console.WriteLine(rp3);
            Console.WriteLine(rp1.Equals(rp3));
        }

        private static void Example4()
        {
            var sp = new StructPerson("ilkay", "kabas");
            Console.WriteLine($"ToString(): {sp}");
        }

        private static void Example6()
        {
            var person = new PersonModel()
            {
                FirstName = "ilkay",
                LastName = "kabas",
                Department = new DepartmentModel()
                {
                    Id = "1",
                    Name = "department 1"
                }
            };

            if (person is PersonModel {Department: {Name: "department 1"}})
            {
                Console.WriteLine("(C#9) department is department 1");
            }

            // if (person is PersonModel {Department.Name: "department 1"})
            // {
            //     Console.WriteLine("(C#10) department is department 1");
            // }

            if (person is PersonModel {Department: {Name: "department 2"}})
            {
                Console.WriteLine("department is department 2");
            }
        }

        private static void Example7()
        {
            Func<string, int> parse = (string s) => int.Parse(s);
            Expression<Func<PersonModel, bool>> expression = e => e.FirstName == "ilkay";
        }

        //[Obsolete($"Call {nameof(PersonModel)}")]
        private static void Example11()
        {
            const string rootPath = "C:\\Users\\hb\\src";
            const string filePath = rootPath + "\\README.md";
            
            //const string filePath = $"{rootPath}\\README.md";
        }
    }
}