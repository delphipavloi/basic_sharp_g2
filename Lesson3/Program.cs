using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string hello = "Hello, World!";
            Console.WriteLine(hello[0]);
            
            a = 1;
            b = 2;
            int result = Calc(a, b);
            int c = 1;
            int d = 1;
            object obj1 = 1;
            Update(obj1);
            Console.WriteLine(obj1);
            Console.WriteLine(IsEqual(a, b));
            Console.WriteLine(IsEqual(c, d));
            Console.WriteLine(CalcObj(2, 4));
            //Console.WriteLine(CalcObj(2, "5"));
            int toModify = 21;
            Modify(ref toModify);
            int toOut;
            ModifyByOut(out toOut);
            Console.WriteLine(toModify);
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            InitArray(array);
            int[] array2;
            CreateArray(out array2);
            Console.ReadLine();
        }

        static void CreateArray(out int[] array)
        {
            array = new int[10];
            InitArray(array);
        }

        static void InitArray(int[] arrayToInit)
        {
            Random random = new Random();
            for (int i = 0; i < arrayToInit.Length; i++)
            {
                arrayToInit[i] = random.Next();
            }
        }

        static void Modify(ref int a)
        {
            a = 123;
        }

        static void ModifyByOut(out int a)
        {
            a = 78;
        }

        static int Calc(int x, int y)
        {
            x = 3;
            y = 6;
            return x + y;
        }

        static bool IsEqual(object a, object b)
        {
            return a == b;
        }

        static int CalcObj(object c, object d)
        {
            int first = (int)c;           
            int second = (int)d;

            c = 4;
            return first + second;
        }
        static void Update(object objectToUpdate)
        {
            objectToUpdate = 42;
        }
    }
}
