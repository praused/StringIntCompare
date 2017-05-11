using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            string apple = "apple";
            string pear = "pear";

            Console.WriteLine(apple.CompareTo(pear));
            Console.WriteLine(pear.CompareTo(apple));
            Console.WriteLine(apple.CompareTo(apple));
        }
    }
}
