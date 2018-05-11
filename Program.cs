using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Class Adam = new Simple_Class(34, "July");
            Simple_Class Lindsey = new Simple_Class(31, "June");

            Console.WriteLine("Hello, World!");
            Console.WriteLine(Adam.Age.GetHashCode());
            Console.WriteLine(Lindsey.Age.GetHashCode());
            Console.WriteLine(Adam.BirthMonth.GetHashCode());
            Console.WriteLine(Lindsey.BirthMonth.GetHashCode());
        }


        

    }
}
