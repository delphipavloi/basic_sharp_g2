using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{    
    class Program
    {
        delegate string SomeDelegate(string obj);
        
        
        static void Main(string[] args)
        {

            Console.WriteLine("2/6 = {0}", Divide(2, 6));

            try
            {
                Console.WriteLine("Start try block");

                Divide(6, 1);
                Log(null);

                Console.WriteLine("Everything is ok :)");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null reference");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Divide(5, 1);
            Log("Vasya");

            Car car = new Car();
            Car car2 = new Car();
            car.Number = "1";
            car2.Number = "2";
            car2.CarIsBroken += Car_CarIsBroken;
            car.CarIsBroken += Car_CarIsBroken;
            try
            {
                for (int i = 0; i < 500; i += 50)
                {
                    car.SetSpeed(i);
                    Console.WriteLine("Current speed is {0}", i);
                }
            }
            catch (TooFastException ex)
            {
                Console.WriteLine(ex);
            }

            car2.SetSpeed(400);


            Cat cat = new Cat();
            Person person = new Person();

            cat.Name = "Murka";
            Cat cat2 = new Cat();
            cat2.Name = "Durka";
            Cat cat3 = new Cat();
            cat3.Name = "Purka";
            Person person2 = new Person();
            person2.PersonName = "Tony";
            Person person3 = new Person();
            person3.PersonName = "Black Widow";

            SomeDelegate del;
            del = cat.SayHello;
            del("David");
            del = cat2.SayHello;
            del("Kuzya");
           
            SayMe(del);
            Func<string, string> func = person.Greetings;
            func("Vasya");

            SomeDelegate multiDel;

            multiDel = cat.SayHello;
            multiDel += cat2.SayHello;
            multiDel += cat3.SayHello;
            multiDel += person.Greetings;
            multiDel += person2.Greetings;
            multiDel += person3.Greetings;
            multiDel("Ultron");


            Console.ReadLine();
        }

        private static void Car_CarIsBroken(Car car, CarBrokeEventArgs eventArgs)
        {
            Console.WriteLine("Car {0} is broken because {1}", car.Number, eventArgs.Reason);
        }

        private static int Divide(int value, int divider)
        {
            return value / divider;
        }

        private static void Log(object objToLog)
        {
            try
            {
                Console.WriteLine(objToLog.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Obj is null!");
            }
            finally
            {
                Console.WriteLine(objToLog.ToString());
            }
        }

        private static void SayMe(SomeDelegate someDel)
        {
            Console.WriteLine(someDel("From meth"));
        } 
    }
}
