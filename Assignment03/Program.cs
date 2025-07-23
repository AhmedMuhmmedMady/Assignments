using System.Buffers.Text;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeChar("mady",1,'b'));
        }

        #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        // Pass by value => Work on Copy of the values but don't change in the original variable
        // Pass by reference => Work and affect on the original variables

        static void PassByValue(int x)
        {
            x += 10;
        }

        static void PassByReference(ref int x)
        {
            x += 10;
        }

        #endregion

        #region 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        // Pass by value =>  Work on Copy of The reference , changes to the object apply.
        // Pass by reference => The reference itself can be changed.

        static void IncementArrayElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 1;
        }

        static void DecrementArrayElements(ref int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
                arr[i] -= 1;
        }

        #endregion

        #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        
        static void SumAndSubtract(int a, int b, int c, int d, out int sum, out int subtract)
        {
            sum = a + b + c + d;
            subtract = a - b - c - d;
        }

        #endregion

        #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Output should be like
        //Enter a number : 25
        //The sum of the digits of the number 25 is : 7
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        // Example usage in Main:
        /*
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");
        */
        #endregion

        #region 5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:
        //static bool IsPrime(int num)
        //{

        //}
        #endregion

        #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        static void MinMaxArray(int[] arr)
        {
            int min , max;
            min = max = arr[0];
            foreach(int item in arr)
            {
                if (item > max)
                    max = item;
                else if (item < min)
                    min = item;
            }
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Min is {min}");
        }
        #endregion

        #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        static int Factorial(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        #endregion

        #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
        static string ChangeChar(string st,int position,char ch)
        {
            char[] ArrayOfChars = st.ToCharArray();
            ArrayOfChars[position] = ch;
            return new string(ArrayOfChars);
        }
        
        
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    if (position < 0 || position >= input.Length)
        //        return input; // invalid position, return original string

        //    char[] chars = input.ToCharArray();
        //    chars[position] = newChar;
        //    return new string(chars);
        //}
        #endregion
    }
}
