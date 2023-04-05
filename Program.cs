using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Output();

            Person person2 = new Person("Oksana", 1986);
            person2.Output();

            Person[] person = new Person[4];
            person[0] = person1;
            person[1] = person2;
            for (int i = 2; i < person.Length; i++)
            {
                person[i] = Person.Input(i);
            }

            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine("Кандидат " + person[i].Name + " Возраст :" + person[i].Age());
            }

            Console.ReadKey();

            string newName = "Very Young";

            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Age() < 16)
                {
                    person[i].Name = newName;
                    Console.WriteLine($"Кандидат {i + 1} : " + newName);
                }
                else
                {
                    Console.WriteLine($"{i + 1} was not changed");
                }
            }

            Console.ReadKey();


            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].ToString());
            }


            Console.ReadKey();

        }
        

       

    }
}

