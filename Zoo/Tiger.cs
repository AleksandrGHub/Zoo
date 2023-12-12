using System;

namespace Zoo
{
    class Tiger : IAnimal
    {
        public Tiger(string gender)
        {
            Type = "Тигры";
            Sound = "Р-р-р!";
            Gender = gender;
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Gender}  тигра    звук {Sound}");
        }

        public string ShowType()
        {
            return Type;
        }
    }
}