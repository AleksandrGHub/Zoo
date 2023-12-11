using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : IAnimal
    {
        public Lion(string gender)
        {
            Type = "Львы";
            Sound = "Р-р-р-р-р!";
            Gender = gender;
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Gender}  льва    звук {Sound}");
        }

        public string ShowType()
        {
            return Type;
        }
    }
}