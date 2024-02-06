using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public class Cat : Animal , IAnimal
    {

        public string Height { get; set; }
        public Cat(string name, string colour = "Black", string height = "23cm", string age = "7") 
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }
        // if you don't want to implement the function make the class abstract

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public string Cry()
        {
            return "Meow!";
        }

        public override string ToString()
        {
            return $"The name of the cat is {this.Name} \n" +
                $"The colour of the cat is {this.Colour} \n" +
                $"The height of the cat is {this.Height} \n" +
                $"The age of the cat is {this.Age} \n";
        }

    }
}
