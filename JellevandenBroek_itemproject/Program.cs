using System;
using System.Collections.Generic;

namespace JellevandenBroek_itemproject
{
    class Program
    {
        static void Main(string[] args)
        {   //PART 1
            //list with 5 items
            Console.WriteLine("PART 1");
            Console.WriteLine("");
            var theItems5 = new List<string>() { "kaas", "boterham", "ham", "jam", "salami" };
            //list with 3 items
            var theItems3 = new List<string>() { "fanta", "cola", "icetea" };

            theItems3.AddRange(theItems5);

            foreach (var names in theItems3)
            {
                // add the item to the list
                Console.WriteLine(names);
            }
            Console.WriteLine("");
            Console.WriteLine("Press enter to go to the next part");
            Console.ReadLine();
            //END PART 1

            //PART 2
            Console.WriteLine("");
            Console.WriteLine("PART 2");
            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("");
            Console.WriteLine("Choose a item!!!!!!!!!!!!!!!!!!!!!!!!!");
            string choice = Console.ReadLine();
            Console.WriteLine("Is this item in the list?: " + theItems3.Contains(choice));
            Console.WriteLine("");
            Console.WriteLine("Press enter to go to the next part");
            Console.ReadLine();
            //END PART 2

            //PART 3
            Console.WriteLine("");
            Console.WriteLine("PART 3");
            Console.WriteLine("");
            Random rnd = new Random();
            int random = rnd.Next(0, 7);

            Console.WriteLine("1 Random item is removed!");
            Console.WriteLine("");
            theItems3.RemoveAt(random);
            theItems3.Sort();
            foreach (var names in theItems3)
            {
                // add the item to the list
                Console.WriteLine(names);
            }
            Console.WriteLine("");
            Console.WriteLine("Press enter to go to the next part");
            Console.ReadLine();
            //END PART 3

            //PART 4
            Console.WriteLine("");
            Console.WriteLine("PART 4");
            Console.WriteLine("");
            for (int i = 4; i < theItems3.Count;)
            {
                theItems3.RemoveAt(i);
            }

            theItems3.Sort();
            theItems3.Reverse();

            foreach (var thing in theItems3)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("");
            Console.WriteLine("Press enter to close the console!");
            Console.ReadLine();
            //END PART 4

        }
    }
}
