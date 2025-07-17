using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            ///Example
            ///Input: 5
            ///Output : 1, 2, 3, 4, 5

            Console.Write("Enter Number: ");
            bool flag1 = int.TryParse(Console.ReadLine(), out int number1);
            for (int i = 1; i <= number1; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            ///Example
            ///Input: 5
            ///Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            Console.Write("Enter Number: ");
            bool Flag2 = int.TryParse(Console.ReadLine(), out int number2);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * number2);
            }
            #endregion

            #region 3 - Write a program that allows the user to insert number then print all even numbers between 1 to this number.
            ///Example:
            ///Input: 15
            ///Output: 2 4 6 8 10 12 14

            Console.Write("Enter Number: ");
            bool flag3 = int.TryParse(Console.ReadLine(), out int number3);
            for (int i = 2; i <= number3; i += 2)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 4 - Write a program that takes two integers then prints the power.
            ///Example:
            ///Input: 4 3
            ///Output: 64
            ///Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            Console.Write("Enter two Integers: ");
            bool flag4 = int.TryParse(Console.ReadLine(), out int number4);
            bool flag5 = int.TryParse(Console.ReadLine(), out int number5);
            int result = 1;
            for (int i = 0; i < number5; i++)
            {
                result *= number4;
            }
            Console.WriteLine(result);
            #endregion

            #region 5 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            ///Example:
            ///Input: 95 76 58 90 89
            ///Output: Total Marks = 408
            ///        Average Marks = 81.6
            ///        Percentage = 81.6

            Console.WriteLine("Enter the Marks of the Five Subjects: ");
            int[] marks = new int[5];
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }
            double average = total / 5.0;
            double percentage = (total / (5.0 * 100)) * 100;
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Percentage = " + percentage + "%");
            #endregion

            #region 6 - Write a program to allow the user to enter a string and print the REVERSE of it.
            ///Example:
            ///Input: Hello
            ///Output: olleH

            Console.Write("Enter a String: ");
            string s = Console.ReadLine();
            string reversedString = "";
            int i1 = s.Length - 1;
            while (i1 >= 0)
            {
                reversedString += s[i1];
                i1--;
            }

            Console.WriteLine(reversedString);
            #endregion

            #region 7 - Write a program to allow the user to enter int and print the REVERSED of it.
            ///Example:
            ///Input: 1234
            ///Output: 4321

            Console.Write("Enter an integer Number: ");
            int n = int.Parse(Console.ReadLine());
            int reversed = 0;
            while (n != 0)
            {
                int remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }
            Console.WriteLine(reversed);
            #endregion

            #region 8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            ///Test Data:
            ///Input starting number of ranges: 1
            ///Input ending number of range: 50
            ///
            ///Expected Output:
            ///The prime numbers between 1 and 50 are:
            ///2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            Console.Write("Input starting number of ranges: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                if (num <= 1) isPrime = false;
                for (int j = 2; j <= Math.Sqrt(num); j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.Write(num + " ");
            }
            Console.WriteLine();
            #endregion

            #region 9 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
            ///Test Data:
            ///Enter a number to convert: 25
            ///Expected Output:
            ///The Binary of 25 is 11001

            Console.WriteLine("Enter the Decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int binary = 0;
            int place = 1;

            while (decimalNumber >= 1)
            {
                int remainder = decimalNumber % 2;
                binary += remainder * place;
                place *= 10;
                decimalNumber /= 2;
            }
            Console.WriteLine("Binary number is: " + binary);
            #endregion

            #region 10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            ///Example:
            ///Input: (0,0), (1,1), (2,2)
            ///Output: The points lie on the same line.

            Console.Write("Enter X1: ");
            int X1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y1: ");
            int Y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter X2: ");
            int X2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y2: ");
            int Y2 = int.Parse(Console.ReadLine());

            Console.Write("Enter X3: ");
            int X3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y3: ");
            int Y3 = int.Parse(Console.ReadLine());

            if ((Y2 - Y1) * (X3 - X1) == (Y3 - Y1) * (X2 - X1))
                Console.WriteLine("These points lie on a single straight line.");
            else
                Console.WriteLine("These points don't lie on a single straight line.");
            #endregion

            #region 11 - Write a program that prints an identity matrix using for loop.
            ///Example:
            ///Input: 3
            ///Output:
            ///1 0 0
            ///0 1 0
            ///0 0 1

            Console.Write("Enter the size of the identity matrix: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
