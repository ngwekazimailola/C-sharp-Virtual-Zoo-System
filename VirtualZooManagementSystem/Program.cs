using System;

namespace VirtualZooManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a virtual zoo
            VirtualZoo zoo = new VirtualZoo();

            // Add some animals to the zoo initially
            zoo.AddAnimal(new Lion { Name = "Alex", Age = 3 });
            zoo.AddAnimal(new Zebra { Name = "Marty", Age = 3 });
            zoo.AddAnimal(new Giraffe { Name = "Melman", Age = 4 });
            zoo.AddAnimal(new Hippo { Name = "Gloria", Age = 5 });
            zoo.AddAnimal(new Lemur { Name = "King Julian", Age = 4 });
            zoo.AddAnimal(new Lemur { Name = "Maurice", Age = 3 });
            zoo.AddAnimal(new Lemur { Name = "Mort", Age = 2 });
            zoo.AddAnimal(new Penguin { Name = "Skipper", Age = 6 });
            zoo.AddAnimal(new Penguin { Name = "Kowalski", Age = 5 });
            zoo.AddAnimal(new Penguin { Name = "Rico", Age = 4 });
            zoo.AddAnimal(new Penguin { Name = "Private", Age = 3 });

            // Main menu For Virtual Zoo
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("*         Welcome to the Virtual Zoo           *");
                Console.WriteLine("*            Management System!                *");
                Console.WriteLine("*----------------------------------------------*");
                Console.WriteLine("* 1. Add an animal                             *");
                Console.WriteLine("* 2. Feed animals                              *");
                Console.WriteLine("* 3. Move animals                              *");
                Console.WriteLine("* 4. Display all animal information            *");
                Console.WriteLine("* 5. Weather Change                            *");
                Console.WriteLine("* 6. Exit                                      *");
                Console.WriteLine("* Select an option:                            *");
                Console.WriteLine("************************************************");
                
                // Read user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddAnimalToZoo(zoo);
                        break;
                    case "2":
                        Console.Write("Enter the type of food options = Meat, Grass, Fish, Fruits, Plants:  ");
                        string food = Console.ReadLine();
                        zoo.FeedAll(food);
                        break;
                    case "3":
                        zoo.MoveAll();
                        break;
                    case "4":
                        zoo.DisplayAllInfo();
                        break;
                    case "5":
                        zoo.WeatherChange();
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        // Method to add an animal to the zoo
        static void AddAnimalToZoo(VirtualZoo zoo)
        {
            Console.WriteLine("Enter details for the new animal:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Please enter a valid age (a non-negative integer).");
                Console.Write("Age: ");
            }

            // Offer animal type options
            Console.WriteLine("Choose the animal type:");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Zebra");
            Console.WriteLine("3. Giraffe");
            Console.WriteLine("4. Hippo");
            Console.WriteLine("5. Lemur");
            Console.WriteLine("6. Penguin");

            // Read user choice
            Console.Write("Enter the number corresponding to the animal type: ");
            string animalTypeInput = Console.ReadLine();

            Animal newAnimal;
            switch (animalTypeInput)
            {
                case "1":
                    newAnimal = new Lion { Name = name, Age = age };
                    break;
                case "2":
                    newAnimal = new Zebra { Name = name, Age = age };
                    break;
                case "3":
                    newAnimal = new Giraffe { Name = name, Age = age };
                    break;
                case "4":
                    newAnimal = new Hippo { Name = name, Age = age };
                    break;
                case "5":
                    newAnimal = new Lemur { Name = name, Age = age };
                    break;
                case "6":
                    newAnimal = new Penguin { Name = name, Age = age };
                    break;
                default:
                    Console.WriteLine("Invalid animal type. Animal not added.");
                    return;
            }

            zoo.AddAnimal(newAnimal);
            Console.WriteLine($"{name} the {newAnimal.GetType().Name} has been added to the zoo!");
        }
    }
}
