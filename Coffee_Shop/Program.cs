using Coffee_Shop.Decorators;
using Coffee_Shop.Models;
using System;
using System.Collections.Generic;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTests();

            Console.Read();
        }

        /// <summary>
        /// This is the API function that the UI will call to get the order info
        /// </summary>
        /// <param name="drink">The name of the base drink</param>
        /// <param name="additions">The additions (can be repeating) for the drink</param>
        /// <returns>The final drink object</returns>
        public static IDrink MakeOrder(string drink, List<string> additions = null)
        {
            IDrink drinkOrder = null;

            switch (drink)
            {
                case "BlackCoffee":
                    drinkOrder = new BlackCoffee();
                    break;
                case "Latte":
                    drinkOrder = new Latte();
                    break;
                case "Mocha":
                    drinkOrder = new Mocha();
                    break;
                case "Tea":
                    drinkOrder = new Tea();
                    break;
                default:
                    break;
            }

            if (additions != null)
            {
                foreach (var addition in additions)
                {
                    switch (addition)
                    {
                        case "Milk":
                            drinkOrder = new MilkDecorator(drinkOrder);
                            break;
                        case "HazelnutSyrup":
                            drinkOrder = new HazelnutSyrupDecorator(drinkOrder);
                            break;
                        case "ChocalateSauce":
                            drinkOrder = new ChocalateSauceDecorator(drinkOrder);
                            break;
                        default:
                            break;
                    }
                }
            }

            return drinkOrder;
        }

        private static void RunTests()
        {
            //EXAMPLE DRINKS TO TEST THE APP

            //Black Coffe with milk
            var blackCoffeeWithMilk = MakeOrder("BlackCoffee", new List<string> { "Milk" });

            //Mocha with double(2x) milk
            var mochaWithDoubleMilk = MakeOrder("Mocha", new List<string> { "Milk", "Milk" });

            //Latte with milk and Hazelnut Syrup
            var latteWithMilkAndHazelnutSyrup = MakeOrder("Latte", new List<string> { "Milk", "HazelnutSyrup" });

            //Mocha with milk and chocalate sauce
            var mochaWithMilkAndChocalateSauce = MakeOrder("Mocha", new List<string> { "Milk", "ChocalateSauce" });

            //Just tea
            var justTea = MakeOrder("Tea");

            Console.WriteLine("*** Tests Results ***");
            EvaluateTestResult(0, blackCoffeeWithMilk.GetCost() == 1.1d);
            EvaluateTestResult(1, mochaWithDoubleMilk.GetCost() == 3.5d);
            EvaluateTestResult(2, latteWithMilkAndHazelnutSyrup.GetCost() == 2.5d);
            EvaluateTestResult(3, mochaWithMilkAndChocalateSauce.GetCost() == 3.9d);
            EvaluateTestResult(4, justTea.GetCost() == 0.5d);

            Console.WriteLine();
            Console.WriteLine("Test Examples");
            Console.WriteLine($"Drink: {blackCoffeeWithMilk.GetName()} - Cost: {blackCoffeeWithMilk.GetCost()}");
            Console.WriteLine($"Drink: {mochaWithDoubleMilk.GetName()} - Cost: {mochaWithDoubleMilk.GetCost()}");
            Console.WriteLine($"Drink: {latteWithMilkAndHazelnutSyrup.GetName()} - Cost: {latteWithMilkAndHazelnutSyrup.GetCost()}");
            Console.WriteLine($"Drink: {mochaWithMilkAndChocalateSauce.GetName()} - Cost: {mochaWithMilkAndChocalateSauce.GetCost()}");
            Console.WriteLine($"Drink: {justTea.GetName()} - Cost: {justTea.GetCost()}");
        }

        private static void EvaluateTestResult(int testCaseNumber, bool compareResult)
        {
            string result = compareResult ? "SUCCESS" : "FAIL";
            Console.WriteLine("TestCase" + testCaseNumber + ": " + result);
        }
    }
}
