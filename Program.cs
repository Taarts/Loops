using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // repeated task x# || until a condition is met
            // process all of the items in a collection

            var counter = 0;

            while (counter < 5) // these stmts do not require a ";" outside {}
            {
                Console.WriteLine("Doughnuts");

                counter++;
            }
            // for LOOP
            /* has 3 parts 
            for(INITIALIZATION; CONDITION; AFTERTHOUGHT){
              //Loop stmts
            "for" Loop is a compact "while" Loop
            } */
            // INITIALIZER
            for (var forCounter = 0; forCounter < 4; forCounter++)
            {
                Console.WriteLine("Doughnuts again");
            }

            var names = new List<string>() { "Gaga", "Bey", "Harry" };

            names.Add("Mel");
            names.Add("Baby");
            names.Add("Posh");

            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            names.Add(name);

            while (name != "quit")
            {
                Console.WriteLine($"  -----{names.Count} people -----");
                //print out whole list 
                // for (var index = 0; index < names.Count; index++)
                // {

                //     var currentName = names[index];
                //     Console.WriteLine(currentName);
                // }

                /* <--------FOREACH */
                // foreach (var currentName in names)
                // {
                //     Console.WriteLine(currentName);
                // }

                // names.Reverse();
                // foreach (var currentName in names)
                // {
                //     Console.WriteLine(currentName);
                // }

                for (var index = names.Count - 1; index >= 0; index--)
                {

                    var currentName = names[index];
                    Console.WriteLine($"The person at index {index} is {currentName}");

                }
                Console.WriteLine();

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                names.Add(name);
            }
            //Pretending we are .NET

        }


    }
}

