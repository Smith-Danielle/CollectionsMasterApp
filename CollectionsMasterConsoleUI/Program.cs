using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50 - Complete
            int[] fifty = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50 - Complete
            Populater(fifty);

            //Print the first number of the array - Complete
            Console.WriteLine("First number:");
            Console.WriteLine(fifty[0]);
            Console.WriteLine("-------------------");

            //Print the last number of the array - Complete          
            Console.WriteLine("Last number:");
            Console.WriteLine(fifty[fifty.Length - 1]);
            Console.WriteLine("-------------------");


            //Use this method to print out your numbers from arrays or lists - Complete
            Console.WriteLine("All Numbers Original");
            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console. - Complete
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(fifty);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArrayTwo(fifty);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers - Complete
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(fifty);
            Console.WriteLine("-------------------");
            Console.WriteLine("Multiple of three = 0: All remaining numbers");
            ThreeKillerTwo(fifty);
            Console.WriteLine("-------------------");

            //Sort the array in order now - Complete
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            SortingArray(fifty);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List - Complete
            List<int> items = new List<int>();

            //Print the capacity of the list to the console - Complete
            Console.WriteLine($"The capicity is {items.Capacity}.");
            Console.WriteLine("---------------------");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this - Complete          
            Populater(items);
            NumberPrinter(items);
            Console.WriteLine("---------------------");

            //Print the new capacity - Complete
            Console.WriteLine($"The new capicity is {items.Capacity}.");
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list - Complete
            //Remember: What if the user types "abc" accident your app should handle that!
            int userGuess;
            bool isNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userGuess);
            }
            while (isNumber == false);
            NumberChecker(items, userGuess);
            Console.WriteLine("-------------------");

            //Print all numbers in the list - Complete
            Console.WriteLine("All Numbers:");
            NumberPrinter(items);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results - Complete
            Console.WriteLine("Evens Only!!");
            OddKiller(items);
            Console.WriteLine("------------------");

            //Sort the list then print results - Complete
            Console.WriteLine("Sorted Evens!!");
            items.Sort();
            NumberPrinter(items);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable - Complete
            var newArray = items.ToArray();

            //Clear the list
            items.Clear();

            #endregion
        }
        private static void SortingArray(int[] numbers)
        // Method to Sort Array
        {
            Array.Sort(numbers);
            NumberPrinter(numbers);

        }
        private static void ThreeKiller(int[] numbers)
        {
          for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;  
                }
                
            }
            NumberPrinter(numbers);

        }
        private static void ThreeKillerTwo(int[] numbers)
        // Method to print all numbers with value (after ThreeKiller) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

        }

        private static void OddKiller(List<int> numberList)
        {
            
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
            
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine($"Yes, {searchNumber} is in the list.");
                }
                else
                {
                    Console.WriteLine($"No, {searchNumber} is not in the list.");
                }
            
        } 

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }
        private static void ReverseArrayTwo(int[] array)
        // Custom reverse method, note this does not assign, just reads it backwards
        {
            for (int i = array.Length - 1; i >= 0; i--)
            { 
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
