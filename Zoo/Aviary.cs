using System;
using System.Collections.Generic;

namespace Zoo
{
    class Aviary
    {
        private List<IAnimal> _animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public void ShowInfo()
        {
            Type type = _animals[0].GetType().BaseType;
            Lion lion = (Lion)_animals[0];
            Console.WriteLine(lion.Gender);

            Console.WriteLine(_animals[0].GetType().GetProperty(Characteristic.Type.ToString()).GetValue(_animals[0], null));
            Console.WriteLine(_animals[0].GetType().GetProperty(Characteristic.Gender.ToString()).GetValue(_animals[0], null));

            Console.WriteLine($"В вольере находятся {_animals[0].ShowType()} - {_animals.Count} особей.");

            foreach (IAnimal animal in _animals)
            {
                animal.ShowInfo();
            }
        }

        public string GetBaseType()
        {
            return _animals[0].GetType().BaseType.Name;
        }
    }
}