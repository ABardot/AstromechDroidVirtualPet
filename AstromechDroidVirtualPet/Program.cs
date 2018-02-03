using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstromechDroidVirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Astromech droid repair program.");
            Console.WriteLine("I see you plugged in an R2 unit.");
            Console.WriteLine("Press Enter to run a diagnostics test.");
            Console.ReadLine();

            // Insert do while
            Console.WriteLine("Here is a diagnostics report on the R2 unit.");
            Console.WriteLine("R2 unit needs cleaning: {0}");
            Console.WriteLine("R2 unit needs new battery: {0}");
            Console.WriteLine("R2 unit needs new tire: {0}");
            Console.WriteLine("\n");


            Console.WriteLine("To clean the R2 unit please press 1");
            Console.WriteLine("To charge the battery on the R2 unit please press 2");
            Console.WriteLine("To change the wheel on R2 unit please press 3");


        }
    }
}
