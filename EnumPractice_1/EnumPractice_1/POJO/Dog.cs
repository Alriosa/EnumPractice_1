using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice_1
{
    public class Dog : Animal
    {
        public Breed breed;

        public Dog(string name , int age, float happiness , Breed breed)
        {
            name = name;
            age = age;
            happiness = happiness;
            breed = this.breed;
        }
    }

    

 
}
