using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static string commonVar = "Common";

        static void Main(string[] args)
        {
            bool test = true;

            test = true ^ false ^ true && false || false || true && false ^ true;

            Console.WriteLine(test);

            int a, b, c;

            //Console.WriteLine("Enter 1st side");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter 2nd side");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter 3rd side");
            //c = Convert.ToInt32(Console.ReadLine());

            bool isExist = false;

            //if ((a + b > c) && (a + c > b) && (b + c > a))
            //{
            //    isExist = true;
            //}


            if (isExist)
            {
                Console.WriteLine("IT'S ALIVE!");
            }
            else
            {
                Console.WriteLine("Sorry, not today");
            }


            string phoneNumber = "";

            Console.WriteLine("Enter your phone number");
            phoneNumber = Console.ReadLine();
            string operatorCode = phoneNumber.Substring(0, 3);

            string operatorName = "Unknown";

            switch (operatorCode)
            {
                case "063":
                    operatorName = "lifecell";

                    break;
                case "097":
                case "068":
                    operatorName = "Kyivstar";
                    break;
                default:
                    operatorName = "I don't know";
                    break;

            }

            string answer = "";

            do
            {
                Console.WriteLine("Enter answer");
                answer = Console.ReadLine();
            } while (answer != "42");

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;                             
            }

            for (int j = 0; j < 10; j += 2)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("**********************************************");
            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Enter number from 0 to 10");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    Console.WriteLine("It's just nothing");
                }
                if (i == 1)
                {
                    Console.WriteLine("Ok, exit");
                    break;
                }
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("Let's try again!");  
            }

            //WriteHello();
            Console.WriteLine(GetRandomNumber());
            Console.ReadLine();
        }

        static void WriteHello()
        {
            Console.WriteLine(commonVar);
            Console.WriteLine("Hello, World!");
        }

        static int GetRandomNumber()
        {
            return 2342;
        }
    }
}
