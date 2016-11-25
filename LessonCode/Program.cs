using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat barsik = new Cat();
            Cat buzefal = new Cat("Buzi", 4);
            Cat barmoley = new Cat("Barmoley", 2, "Sphinx");
            Cat marusya = null;
            marusya.BringFlipFlop("Yellow");
            barsik.Name = "Barsik";
            barsik.Age = 200;
            Cat.DoYouLikeCats();
            Console.WriteLine("There are {0} cats now", Cat.Popualtion);
            barsik.Meow();
            barsik.BringFlipFlop("Pink with bears");
            barmoley.BringFlipFlop("Green");
            Console.WriteLine(barsik.Name);

            Console.ReadLine();
        }
    }
}
