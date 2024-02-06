using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }



        public abstract void Eat();

        public abstract string Cry();

    }
}
