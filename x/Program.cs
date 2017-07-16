using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Tom", 25);
            person.Talks();

            Console.WriteLine("\n");
        }
    }
}
