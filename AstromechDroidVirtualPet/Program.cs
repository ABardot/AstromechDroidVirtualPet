using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstromechDroidVirtualPet
{
    class Program
    {
        static void Main()
        {
            int userChoice;
            AstromechDroid userDroid = new AstromechDroid();
            Console.WriteLine("Welcome to the Astromech droid repair program.");
            Console.WriteLine("I see you plugged in an R2 unit.");
            Console.WriteLine("Press Enter to run a diagnostics test.");
            Console.ReadLine();

            do
            {
                Console.WriteLine("Here is a diagnostics report on the R2 unit.");
                Console.WriteLine("R2 unit needs cleaning: {0}");
                Console.WriteLine("R2 unit needs new battery: {0}");
                Console.WriteLine("R2 unit needs new tire: {0}");
                Console.WriteLine("\n");
                Console.WriteLine("To clean the R2 unit please press 1");
                Console.WriteLine("To charge the battery on the R2 unit please press 2");
                Console.WriteLine("To change the wheel on R2 unit please press 3");
                Console.WriteLine("To exit program press 4");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine(userDroid.Clean());
                        break;
                    case 2:
                        Console.WriteLine(userDroid.Battery());
                        break;
                    case 3:
                        Console.WriteLine(userDroid.Wheel());
                        break;
                    
                    default:
                        break;
                }
            } while (userChoice != 4);
        }
    }
}
