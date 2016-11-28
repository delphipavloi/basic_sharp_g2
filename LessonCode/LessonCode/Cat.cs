using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        public Cat(string name) : base(name)
        {

        }

        public void RunForDot()
        {                       
            Console.WriteLine("I'm {0} years old and clever enough to not run.", age);
        }
    }
}
