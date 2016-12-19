using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Cat
    {
        public string Name { set; get; } 

        public string SayHello(string name)
        {
            Console.WriteLine("I'm cat {0}, hi, {1}", Name, name);
            return String.Format("I'm cat {0}, hi", Name);
        }
    }
}
