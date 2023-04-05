using System;
using System.Diagnostics;
using System.Drawing;

namespace HomeWork4_1
{
	public class Person
	{
		private string name;
		private int birthYear;
		private int age;
		public const int todayYear = 2023;

		public readonly struct DateTime
		{

		}

		public string Name
		{
			get { return name; }
			set { name = value; }

		}

		public Person()
		{
			name = "Fedir";
			birthYear = 1985;
		}

		public Person(string name, int birthYear)
		{
			this.name = name;
			this.birthYear = birthYear;
		}

		public int Age()
		{
			age = todayYear - birthYear;
			return age;
		}
		//public void Age()
		//{
		//   var today = DateTime.Today;
		//    age = today.Year - birthYear.Year;
		//    return age;

		//}
        public static Person Input(int i)
		{
			Console.WriteLine($"Введите имя кандидата {i + 1}");
			string name = Console.ReadLine();
			Console.WriteLine($"Год рождения кандидата {i + 1}");
			int birthYear = Convert.ToInt32(Console.ReadLine());
			Person person = new Person(name, birthYear);
			return person;
		}

		public void Output()
		{
			Console.WriteLine("Person {}");
            Console.WriteLine("Name: " + name);
			Console.WriteLine("Birth year: " + birthYear);
		}
        public override string ToString()
        {
            return  "Кандидат" + name + "  Возраст:" + age;
        }
    }
}

