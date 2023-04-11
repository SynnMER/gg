using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
    internal class Program
    {
        static List<Person> Ask_N_Times(int n)
        {
            var ans2 = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans2.Add(CreatePerson());
            }
            return ans2;
        }
        static public Person CreatePerson()
        {
            string name;
            string seasons = "";
            int age = 0;
            Console.WriteLine("Введите имя ");
            name = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Возраст введен некоpректно");
                }

            }
            while (age < 5 && age > 80);
            do
            {
                try
                {
                    Console.WriteLine("Введите время года");
                    seasons = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Время года введено некоpректно");
                }

            }
            while (seasons != "String" && seasons != "Automn" && seasons != "Summer" && seasons != "Winter");

            var person = new Person(name);
            person.Age = age;
            person.Seasons = seasons;
            return person;
        }

        static void Main(string[] args)
        {
            var PersonList = Ask_N_Times(2);
            var list = PersonList.OrderBy(a => a.Age);
            foreach (Person person in list)
            {
                Console.WriteLine($"Имя {person.Name}," + $" Возраст {person.Age}" + $" Время года {person.Seasons}");
            }

        }
    }
}
