using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Animal
    {
        public string Name { set; get; }

        protected int age = 1;

        public Animal(string name)
        {

        }

        public virtual void Speak()
        {            
            Console.WriteLine("Animal speaks. But how?");
        }

        public void HowOld()
        {
            Console.WriteLine("It's {0} years old", age);
        }
    }
}
