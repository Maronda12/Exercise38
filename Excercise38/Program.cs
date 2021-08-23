using System;
using System.Linq;

namespace Excercise38
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray = new int[5]; //Creates Array

            bool goOn = true;
            while (goOn == true)
            {

                //Gets Numbers
                Console.WriteLine("Please enter your first number:");
                numArray[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number:");
                numArray[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your third number:");
                numArray[2] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your fourth number:");
                numArray[3] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your fifth number:");
                numArray[4] = Convert.ToInt32(Console.ReadLine());

                //Average of all numbers in Array
                double average = numArray.Average();
                Console.WriteLine($"({numArray[0]} + {numArray[1]} + {numArray[2]} + {numArray[3]} + {numArray[4]}) / 5 = {average}");

                goOn = GetContinue(); // Calls Continue Method


            }


        } //Continue Method
           public static bool GetContinue()
           {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");

                return GetContinue();
            }

           }

    }
}
