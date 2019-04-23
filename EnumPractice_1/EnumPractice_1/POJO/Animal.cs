using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice_1
{
    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public float happiness { get; set; }

        public Animal()
        {
        }

        public Animal(string name , int age, float happiness)
        {
            name = name;
            age = age;
            happiness = happiness;
        }
    }

    
}
