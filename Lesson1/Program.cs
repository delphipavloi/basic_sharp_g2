using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "Hello, world!";

            int i = 0;           

            Console.WriteLine(userInput);
            Console.WriteLine(i);
            userInput = Console.ReadLine();
            i = Convert.ToInt32(userInput);            
            Console.WriteLine("You entered: " + i);
            if (i == 42)
            {
                Console.WriteLine("This is the Answer!");
            }
            else
            {
                Console.WriteLine("Not the Answer!");
            }

            Console.ReadLine();
        }
    }
}
