
using System;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is : " + number);
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string input = "abc";
            //int result = (int) input;

            // this will compile, but at runtime it throws exception because string cannot be explicitly cast to int.

            Console.WriteLine("Converted number: " + input);
            #endregion


            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float a = 10.54444f;
            float b = 3.222f;
            float sum = a + b;
            Console.WriteLine("The sum is : " + sum); //will happen rounding
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            string sentence = "Hello World";
            string subString = sentence.Substring(1, 4);
            Console.WriteLine("The Substring is : " + subString);
            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 5;
            int y = x;
            y = 10;
            Console.WriteLine("x = " + x + ", y = " + y); // x will still 5 because value types are copied by value
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 100;  //arr1[0] is 100 because both refer to the same array
            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
            string s1 = "Hello";
            string s2 = "World";
            string result = s1 + " " + s2;
            Console.WriteLine("Combined string : " + result);
            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.
            Console.Write("Enter principal: ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Enter rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter time: ");
            double time = double.Parse(Console.ReadLine());
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest = " + interest);
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            Console.Write("Enter weight in kilograms : ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter height in meters : ");
            double height = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("BMI = " + bmi);
            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            Console.Write("Enter temperature : ");
            int temp = int.Parse(Console.ReadLine());
            string result2;

            if (temp < 10)
                result2 = "Just Cold";
            else if (temp > 30)
                result2 = "Just Hot";
            else
                result2 = "Just Good";
            Console.WriteLine("Result : " + result2);
            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            Console.Write("Enter day : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");
            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            Console.Write("Enter an integer: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3
            Console.Write("Enter first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            int num3 = int.Parse(Console.ReadLine());
            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);
            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter a number : ");
            int x2 = int.Parse(Console.ReadLine());
            if (x2 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            Console.Write("Enter month number : ");
            int monthNumber = int.Parse(Console.ReadLine());
            int daysInMonth = 0;

            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30; break;
                case 2:
                    daysInMonth = 28; break;
            }

            Console.WriteLine("Days in Month: " + daysInMonth);
            #endregion
        }
    }
}