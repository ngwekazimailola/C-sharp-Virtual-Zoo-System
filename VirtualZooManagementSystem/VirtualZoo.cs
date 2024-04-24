using System.Collections.Generic;

namespace VirtualZooManagementSystem
{
    public class VirtualZoo
    {
        private List<Animal> animals;

        public List<Animal> Animals { get => animals; }

        // Constructor to initialize the virtual zoo
        public VirtualZoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void FeedAll(string food)
        {
            foreach (var animal in animals)
            {
                if (animal is IFeedable feedable)
                {
                    feedable.Feed(food);
                }
            }
        }

        public void MoveAll()
        {
            foreach (var animal in animals)
            {
                if (animal is IMovable movable)
                {
                    movable.Move();
                }
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void DisplayAllInfo()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
            }
        }

        public void WeatherChange()
        {
            //Choosing random weather
            Random random = new Random();
            int weatherCode = random.Next(1, 4);

            string weather = "";
            switch (weatherCode)
            {
                case 1:
                    weather = "Rainy";
                    break;
                case 2:
                    weather = "Sunny";
                    break;
                case 3:
                    weather = "Snowy";
                    break;
            }

            Console.WriteLine($"Weather changes: {weather} day!");

            // How Animals behave in differnt weather conditions
            foreach (var animal in animals)
            {
                if (weather == "Rainy")
                {
                    if (animal is Lion || animal is Zebra || animal is Giraffe)
                    {
                        Console.WriteLine($"{animal.Name} seeks shelter from the rain.");
                    }
                    else
                    {
                        Console.WriteLine($"{animal.Name} enjoys the rain.");
                    }
                }
                else if (weather == "Sunny")
                {
                    Console.WriteLine($"{animal.Name} plays and basks the sunshine.");
                }
                else if (weather == "Snowy")
                {
                    Console.WriteLine($"{animal.Name} hides from the heavy snow.");
                }
            }
        }
    }

}