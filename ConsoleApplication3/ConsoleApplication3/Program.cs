using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Cat
    {
        // Field name
        private static string name;
        // Field color
        private string color;

        // Default constructor
        public Cat()
        {
            //this.name = "Unnamed";
            this.color = "gray";
        }

        // Constructor with parameters
        public Cat(String name, String color)
        {
            //this.name = name;
            this.color = color;
        }

        // Method sayMiau
        public static void sayMiau()
        {
            Console.WriteLine("Cat %s said: Miauuuuuu! {0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat.sayMiau();
        }
    }
}
