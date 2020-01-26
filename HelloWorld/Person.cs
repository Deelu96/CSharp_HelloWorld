using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        private static String name;

        public static String getName()
        {
            return name;
        }

        public static void setName(String _name)
        {
            name = _name;
        }
    }
}
