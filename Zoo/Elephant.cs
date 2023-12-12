using System;

namespace Zoo
{
    class Elephant : IAnimal
    {
        public Elephant(string gender)
        {
            Type = "Слоны";
            Sound = "Фр-р-фр!";
            Gender = gender;
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Gender}  слона    звук {Sound}");
        }

        public string ShowType()
        {
            return Type;
        }
    }
}