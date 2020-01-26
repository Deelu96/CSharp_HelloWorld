using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        //fields
        private  String firstName;
        public  String LastName { get; set; }
        public int Age { get; set; }

        //property_or_attribute
        public  String GetFirstName()
        {
            return this.firstName;
        }

        public  void SetFirstName(String _firstName)
        {
            firstName = _firstName;
        }

        public void PrintData()
        {
            Console.Out.WriteLine("\n\nName : " + GetFirstName() + " " + LastName);
            Console.Out.WriteLine("Age : " + Age);
            Console.WriteLine("\n\n\nThank you!");
        }
    }
}
