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
            Console.Out.WriteLine("Hello World!");
            String x, y = null;

            x = Console.ReadLine();
            
            Person.setName(x);
         
            Console.Out.WriteLine("Hello : " + Person.getName());



            y = Console.ReadLine();
        }
    }
}
