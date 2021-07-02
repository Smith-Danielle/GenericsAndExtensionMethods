using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO DONE - Create a class called "Storage" that has a generic Type "T".
        //TODO DONE - In your class create a property List called "Bin". Set the list type to "T".
        //TODO DONE - Create two more classes. One class called "Equipment". The second class called "Food".
        //TODO DONE - create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO DONE - create some instanes of type Food and Equipment and Add them the correct storage bins.

        //TODO DONE - In the program class Create a static void method called CountToNum that has a generic type called "T".
        //TODO DONE - Give the method a T paramter called "n".
        //TODO DONE - In the method scope make the method print all the numbers from 0 to "n".
        //TODO DONE - Call the method in the Main first by giving it a float number. Then call it again by giving it a double number.

        public static void CountToNum<T>(T n)
        {
            for (int i = 0; i < Convert.ToInt32(n) + 1; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {

            var equipStorage = new Storage<Equipment>();
            var foodStorage = new Storage<Food>();

            var equip1 = new Equipment() { Name = "Computer", Price = 2000.99 };
            equipStorage.Bin.Add(equip1);
            var equip2 = new Equipment() { Name = "Television", Price = 500.50 };
            equipStorage.Bin.Add(equip2);
            var equip3 = new Equipment() { Name = "Phone", Price = 1500.75 };
            equipStorage.Bin.Add(equip3);

            var food1 = new Food() { Name = "Pizza", Price = 25.99 };
            foodStorage.Bin.Add(food1);
            var food2 = new Food() { Name = "Burger", Price = 7.50 };
            foodStorage.Bin.Add(food2);
            var food3 = new Food() { Name = "Fries", Price = 2.75 };
            foodStorage.Bin.Add(food3);

            Console.WriteLine("The Equipment consists of:");
            Console.WriteLine("----------------------------------------");
            int counter = 1;
            foreach (var item in equipStorage.Bin)
            {

                Console.WriteLine($"Item {counter}: {item.Name} at {item.Price} ");
                counter++;
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("The Food consists of:");
            Console.WriteLine("----------------------------------------");
            int counter1 = 1;
            foreach (var item in equipStorage.Bin)
            {

                Console.WriteLine($"Item {counter}: {item.Name} at {item.Price} ");
                counter1++;
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Please enter an integer to count from 0 to.");
            Console.WriteLine("----------------------------------------");
            int inputInteger = int.Parse(Console.ReadLine());
            CountToNum(inputInteger);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Please enter a float to count from 0 to.");
            Console.WriteLine("----------------------------------------");
            float inputFloat = float.Parse(Console.ReadLine());
            CountToNum(inputFloat);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Please enter a double to count from 0 to.");
            Console.WriteLine("----------------------------------------");
            double inputDouble = double.Parse(Console.ReadLine());
            CountToNum(inputDouble);
            Console.WriteLine("----------------------------------------");


            //ExtensionMethods
            //TODO DONE - Create a static class called "ExtensionMethods"
            //TODO DONE - in your new class create an extension method called "FindOdds" this method should take an IEnumerable of type integers and return a new IEnumerable of only the odd integers. Use linq in the scope to find odd numbers.

            //TODO DONE - Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement
            //TODO DONE - call both extension methods in the Main. Use the method on the numbers Array.

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Odds");
            Console.WriteLine("----------------------------------------");
            var oddOnes = numbers.FindOdds();
            foreach (var item in oddOnes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("All");
            Console.WriteLine("----------------------------------------");
            var numsSorted = numbers.SortArray();
            foreach (var item in numsSorted)
            {
                Console.WriteLine(item);
            }
        }

    }
}
