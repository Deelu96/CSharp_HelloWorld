using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Out.WriteLine("Hello World!");
            int age;

            Console.Out.WriteLine("\n\nFirst Name : ");
            String firstName = Console.ReadLine();
            person.SetFirstName(firstName);

            Console.Out.WriteLine("\nSecond Name : ");
            String lastName = Console.ReadLine();
            person.LastName = lastName;

            Console.Out.WriteLine("\nAge : ");
            age = Convert.ToInt32(Console.ReadLine());
            person.Age = age;

            person.PrintData();
        }
    }
}
