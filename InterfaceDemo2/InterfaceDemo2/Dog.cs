using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public class Dog : Animal, IAnimal
    {
        //Properties in interface must also be implemented
        //overriding or implementing properties from IHabitat interfaces
        public string Height {  get; set; }
        public Dog(string name, string colour = "Brown", string height = "71cm", string age = "5") 
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }

        //implemented inherited abstract method from
        //abstract Animal

        //implementing method from IFeedable Interface
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        //implement method from IHabitat interface
        public string Cry()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"The name of the dog is {this.Name} \n" +
                $"The colour of the dog is {this.Colour} \n" +
                $"The height of the dog is {this.Height} \n" +
                $"The age of the dog is {this.Age} \n";
        }
    }
}
