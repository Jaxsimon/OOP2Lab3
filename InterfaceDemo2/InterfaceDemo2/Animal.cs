using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public string Colour { get; set; }
        public string Age { get; set; }

        public Animal() 
        { 
        
        }

        public abstract void Eat();


        public override string ToString()
        {
            return $"The name of the animal is {this.Name} \n" +
                $"The colour of the animal is {this.Colour} \n" +
                $"The age of the animal is {this.Age} \n";     
        }

    }
}
