using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Cat
    {
        public static void DoYouLikeCats()
        {
            Console.WriteLine("Yes");
            
                        
        }

        public static int Popualtion { private set; get; }



        private string name;
        private int age;

        public Cat()
        {
            name = "Unknown";
            age = 1;
            Breed = "Dvoryanin";
            Popualtion++;
        }

        public Cat(string name, int age) : this()
        {
            this.name = name;
            this.age = age;           
        }

        public Cat(string name, int age, string breed) : this(name, age)
        {
            Breed = breed;
        }


        public Cat(int age, string breed) : this("Tutu", age, breed)
        {

        }

        public string Breed { set; get; }

        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {                
                if (value > 20)
                {
                    age = 20;
                    return;
                }
                age = value;
                //else
                //{
                //    age = value;
                //}
                                
            }
            get
            {
                return age;
            }
        }

        public void Meow()
        {
            Console.WriteLine("Meow! My name is {0}, I'm {1} years old", name, age);
        }

        public void BringFlipFlop(string flipFlopColor)
        {
            Console.WriteLine("I'm cat, man. I can't bring this {0} flipflop", flipFlopColor);
                   
        }


    }
}
