using System;

namespace Zoo
{
    class Horse : IAnimal
    {
        public Horse(string gender)
        {
            Type = "Лошади";
            Sound = "И-и-и-го-го!";
            Gender = gender;
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Gender}  лошади    звук {Sound}");
        }

        public string ShowType()
        {
            return Type;
        }
    }
}