using System;
using System.Collections.Generic;

namespace ch6_sets
{
    class CarSets
    {
        static void Main(string[] args)
        {
            List<string> Inventory = new List<string>()
{
    "Camry", "F-150", "MDX", "Camry", "Camry",
    "Taurus", "F-150", "MDX", "Camry", "Xterra",
    "Mustang", "Suburban", "Santa Fe", "F-150", "Camry",
    "F-150", "F-150", "Mustang", "Camry", "Camry",
    "Camry", "Escalade", "Q30", "Camry", "MDX",
};
            // There is repetitive code in this object: "Camry" is listed 9 times!

            HashSet<string> allModels = new HashSet<string>();

            // iterate through Inventorty and create a new HashSet called allModels. Each item in Inventory becomes a "model" in the HashSet:
            foreach (string model in Inventory)
            {
                allModels.Add(model);
            }

            // Display all unique model names
            foreach (string vehicle in allModels)
            {
                // Console.WriteLine($"{vehicle}");
            }

            /*
                Output

                Camry
                F-150
                MDX
                Taurus
                Xterra
                Mustang
                Suburban
                Santa Fe
                Escalade
                Q30
            */
            //===================================================================================

            //  1. Create an empty HashSet named Showroom that will contain strings
            //  2. Add four of your favorite car model names to the set.
            //  3. Print to the console how many cars are in your show room.
            //  4. Pick one of the items in your show room and add it to the set again.
            //  5. Print your showroom again, and notice how there's still only one representation of that model in there.
            //  6. Create another set named UsedLot and add two more car model strings to it.
            //  7. Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            //  8. You've sold one of your cars. Remove it from the set with the Remove() method.


            HashSet<string> Showroom = new HashSet<string>();

            foreach (string favModel in Inventory)
            {
                Showroom.Add("F-150");
                Showroom.Add("MDX");
                Showroom.Add("Xterra");
                Showroom.Add("Q30");
                Showroom.Add("Q30");
            }

            foreach (string favModel in Showroom)
            {
                Console.WriteLine($"My favorite models: {favModel}");
            }
            Console.WriteLine($"Number of items in showroom: {Showroom.Count}");


            HashSet<string> UsedLot = new HashSet<string>();

            foreach (string usedModel in Inventory)
            {
                UsedLot.Add("Camry");
                UsedLot.Add("Taurus");
            }

            foreach (string usedModel in UsedLot)
            {
                Console.WriteLine($"Old models: {usedModel}");
            }

            Showroom.UnionWith(UsedLot);

            foreach (string allCars in Showroom)
            {
                Console.WriteLine(allCars);
            }

            if (Showroom.Contains("Camry") == true)
            {
                Showroom.Remove("Camry");
            }

            foreach (string allCars in Showroom)
            {
                Console.WriteLine($"All Cars in Showroom except for Camry: {allCars}");
            }


        }
    }
}



//===================================================================================


//===================================================================================


//===================================================================================


//===================================================================================


//===================================================================================
