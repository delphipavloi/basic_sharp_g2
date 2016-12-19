using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Person
    {
        public string PersonName { set; get; }
        public string Greetings(string toWho)
        {
            Console.WriteLine("Hi, {0}, I'm {1}", toWho, PersonName);
            return String.Format("Hi, {0}, I'm Dotor. Doctor Who", toWho);
        }
    }
}
