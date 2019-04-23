using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static EnumPractice_1.Dog;

namespace EnumPractice_1
{

    enum Breed
    {
        Bulldog,
        Boxer,
        Chihuahua,
        Briard
    };

    class MainClass
    {

        class Animal
        {
            public string name;
            public int age;
            public float happiness;
        }

        class Dog : Animal
        {
            public Breed breed;

            public Dog(string name, int age, float happiness, Breed breed)
            {
                name = name;
                age = age;
                happiness = happiness;
                breed = breed;
            }
        }

        public static void Main(string[] args)
        {

       



        Console.WriteLine("Name" + name);
        Console.WriteLine("Age" + age);
        Console.WriteLine("Happiness" + happiness);
         

        }
    }
}
