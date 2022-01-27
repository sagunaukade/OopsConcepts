using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public int weight;
        public string color;
        public string name;
         
        public void Sound()
        {
            Console.WriteLine("Sound..");
        }
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public class Dog : Animal
        { 
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
            public class BabyDog : Animal
            {
                public void Eat()
                {
                    Console.WriteLine("Eating...");
                }

                public static void Main()
                {
                    BabyDog b = new BabyDog();
                    b.Sound();
                    b.Weep();
                    b,Eate();

                }

            }
        }
    }
}
