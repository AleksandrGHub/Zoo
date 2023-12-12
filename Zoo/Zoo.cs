using System;
using System.Collections.Generic;

namespace Zoo
{
    class Zoo
    {
        private Random _random = new Random();

        private List<Aviary> _aviaries = new List<Aviary>();

        private AbstractFactory[] _factories = new AbstractFactory[] { new MaleFactory(), new FemaleFactory() };

        public void AddAnimal()
        {
            int maxNumberTypes = 5;
            int maxNumberAnimals = 7;

            Aviary aviary;

            IAnimal animal = null;

            for (int numberType = 0; numberType < maxNumberTypes; numberType++)
            {
                aviary = new Aviary();

                for (int numberAnimal = 0; numberAnimal < maxNumberAnimals; numberAnimal++)
                {
                    int randomIndex = _random.Next(_factories.Length);

                    switch (numberType)
                    {
                        case (int)TypeAnimal.Lion:
                            animal = GetLion(_factories[randomIndex]);
                            break;

                        case (int)TypeAnimal.Bear:
                            animal = GetBear(_factories[randomIndex]);
                            break;

                        case (int)TypeAnimal.Horse:
                            animal = GetHorse(_factories[randomIndex]);
                            break;

                        case (int)TypeAnimal.Tiger:
                            animal = GetTiger(_factories[randomIndex]);
                            break;

                        case (int)TypeAnimal.Elephant:
                            animal = GetElephant(_factories[randomIndex]);
                            break;
                    }

                    aviary.AddAnimal(animal);
                }

                _aviaries.Add(aviary);
            }
        }

        public void ShowAviary(string type)
        {
            foreach (Aviary aviary in _aviaries)
            {
                if (aviary.GetBaseType() == type)
                {
                    aviary.ShowInfo();
                }
            }

            Console.ReadKey();
            Console.Clear();
        }

        private IAnimal GetLion(AbstractFactory factory)
        {
            return factory.CreateLion();
        }

        private IAnimal GetBear(AbstractFactory factory)
        {
            return factory.CreateBear();
        }

        private IAnimal GetHorse(AbstractFactory factory)
        {
            return factory.CreateHorse();
        }

        private IAnimal GetTiger(AbstractFactory factory)
        {
            return factory.CreateTiger();
        }

        private IAnimal GetElephant(AbstractFactory factory)
        {
            return factory.CreateElephant();
        }
    }
}