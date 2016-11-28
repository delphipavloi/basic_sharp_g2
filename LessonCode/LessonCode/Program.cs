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
            Animal animal = new Animal("Boris the Animal");
            Cat cat = new Cat("Barsik");
            Dog dog = new Dog("Tuzik");
            Animal animalCat = new Cat("Barsik the Animal");
            Animal animalDog = new Dog("Tuzik the Animal");


            animal.Speak();
            cat.Speak();
            dog.Speak();
            animalCat.Speak();

            Animal[] animalsArray = new Animal[5];
            animalsArray[0] = animal;
            animalsArray[1] = cat;
            animalsArray[2] = dog;
            animalsArray[3] = animalCat;
            animalsArray[4] = animalDog;

            cat.HowOld();
            
            Zoo(animalsArray);
            Console.ReadLine();
        }

        static void Zoo(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Speak();
            }
        }


    }
}
