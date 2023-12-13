using System;

namespace Zoo
{
    class Menu
    {
        private const string LookLionCommand = "lion";
        private const string LookBearCommand = "bear";
        private const string LookHorseCommand = "horse";
        private const string LookTigerCommand = "tiger";
        private const string LookElephantCommand = "elephant";
        private const string ExitCommand = "exit";

        private Zoo _zoo = new Zoo();

        public void Work()
        {
            string userInput;

            _zoo.AddAnimals();

            do
            {
                Console.Clear();
                Show();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case LookLionCommand:
                        _zoo.ShowAviary(TypeAnimal.Lion.ToString());
                        break;

                    case LookBearCommand:
                        _zoo.ShowAviary(TypeAnimal.Bear.ToString());
                        break;

                    case LookHorseCommand:
                        _zoo.ShowAviary(TypeAnimal.Horse.ToString());
                        break;

                    case LookTigerCommand:
                        _zoo.ShowAviary(TypeAnimal.Tiger.ToString());
                        break;

                    case LookElephantCommand:
                        _zoo.ShowAviary(TypeAnimal.Elephant.ToString());
                        break;
                }
            } while (userInput != ExitCommand);
        }

        private void Show()
        {
            Console.WriteLine("**********************Меню**********************");
            Console.WriteLine($"Посмотреть вольер со львами     (команда: {LookLionCommand})");
            Console.WriteLine($"Посмотреть вольер с медведями   (команда: {LookBearCommand})");
            Console.WriteLine($"Посмотреть вольер с лошадьми   (команда: {LookHorseCommand})");
            Console.WriteLine($"Посмотреть вольер с тиграми   (команда: {LookTigerCommand})");
            Console.WriteLine($"Посмотреть вольер со слонами   (команда: {LookElephantCommand})");
            Console.WriteLine($"Выйти                           (команда: {ExitCommand})");
        }
    }
}