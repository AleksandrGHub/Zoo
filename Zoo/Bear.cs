using System;

namespace Zoo
{
    class Bear : IAnimal
    {
        public Bear(string gender)
        {
            Type = "Медведи";
            Sound = "Ря-я-я-яв!";
            Gender = gender;
        }

        public string Type { get; private set; }
        public string Gender { get; private set; }
        public string Sound { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Gender}  медведя    звук {Sound}");
        }

        public string ShowType()
        {
            return Type;
        }
    }
}