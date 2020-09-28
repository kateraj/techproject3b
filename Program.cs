/*
 
Author: Katera Jefferson
Date: 9/27/2020
Comments: This C# Console Application code demonstrates the use of Arrays after getting input from users

*/

using System;

namespace techproject3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 1 and 25: ");
            /*
             Try-catch block to validate user-input
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will perform various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // manually populate an array and iterate its values if value of user input is between 1 and 25
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, let's manually populate an array with integers and iterate the elemets");
                    //manually populated array
                    int[] numbers = { 1, 8, 13, 9, 2, 16, 2, 2, 22, 10, 4 };
                    Console.WriteLine("________________________________________");
                    Console.WriteLine("The value is " + numbers[value_of_input] + "element #" + value_of_input + "of the array.");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine("");
                    //iterate through the array with a Foreseen Loop
                    foreach (int i in numbers)
                    {
                        Console.WriteLine(i + "");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Press any key to exit the program...");
                    // end program when user presses key
                    Console.ReadKey(true);
                }
            catch
            {

            }
        }
    }
}

