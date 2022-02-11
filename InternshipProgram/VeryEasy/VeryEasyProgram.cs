using System;

namespace InternshipProgram.VeryEasy
{
    public static class VeryEasyProgram
    {
        /// <summary>
        /// Method that returns true
        /// </summary>
        public static bool ReturnTrue()
        {
            return true;
        }
        
        /// <summary>
        /// Create a function that takes two numbers as arguments and return their sum
        /// </summary>
        public static int Sum(int a, int b)
        {
            int sum = a + b;

            return sum;
        }
        
        /// <summary>
        /// Write a function that takes an integer minutes and converts it to seconds
        /// </summary>
        public static int ConverMinutesToSeconds(int minutes)
        {
            int seconds = minutes * 60;
            
            return seconds;
        }
        
        /// <summary>
        /// Create a function that returns true if an integer is evenly divisible by 5, and false otherwise
        /// </summary>
        public static bool DivisibleByFive(int number)
        {
            int rest = number % 5;

            if (rest == 0)
            {
                return true;
            }

            return false;
        }
        
        /// <summary>
        /// Create a function that takes two numbers and a mathematical operator and returns the result
        /// </summary>
        public static int Calculate(int num1, int num2, string operation)
        {
            if (operation == "+")
            {
                int result = num1 + num2;
                return result;
            } 
            else if (operation == "-")
            {
                int result = num1 - num2;
                return result;
            }
            else if (operation == "*")
            {
                int result = num1 * num2;
                return result;
            }
            else if (operation == "/")
            {
                int result = num1 / num2;
                return result;
            }
            else
            {
                int result = num1 % num2;
                return result;
            }
        }
        
        /// <summary>
        /// Write a function to reverse an array
        /// </summary>
        public static int[] Reverse(int[] array)
        {
            int[] reverse = new int[array.Length];
            int count = 0;
            int i = array.Length - 1;

            while (count < array.Length)
            {
                reverse[count] = array[i];
                count++;
                i--;
            }

            return reverse;
        }
        
        /// <summary>
        /// Create a function that takes a string and returns the concatenated first and last character
        /// </summary>
        public static string FirstLastCharacter(string a)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM
        /// </summary>
        public static string FormatDateYYYYDDMM(string date)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Create a function that returns the average of a list of numbers
        /// </summary>
        public static double Average(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
