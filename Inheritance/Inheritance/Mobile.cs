using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Mobile
    {
        public int price;
        public string name;
        public string color;

        public void Chatting()
        {
            Console.WriteLine(" Chatting...");
        }
        public void Calling()
        {
            Console.WriteLine("Calling...");
        }
        public void Music()
        {
            Console.WriteLine("Music....");
        }
        public class Inheritance
        {
            public static void Main()
            {
                Mobile m1 = new Mobile();
                //properties
                m1.price = 200000;
                m1.name = "Poco C3";
                m1.color = "Gray";
                Console.WriteLine(m1.price);
                Console.WriteLine(m1.color);
                Console.WriteLine(m1.name);


                //behaviour
                m1.Chatting();
                m1.Calling();
                m1.Music();

            }
        }
    }
}
    

