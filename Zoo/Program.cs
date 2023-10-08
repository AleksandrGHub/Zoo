using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Zoo
    {

    }

    class Aviary
    {

    }

    class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }
    }
}