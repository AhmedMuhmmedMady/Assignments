using System.Numerics;

namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration1 = new Duration(3600);
            Duration duration2 = new Duration(3600);
            Duration duration = duration1++;
            Console.WriteLine(duration.ToString());
        }
    }
    #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
    //●	Accept two integers and return their sum.
    //●	Accept three integers and return their sum.
    //●	Accept two doubles and return their sum.

    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
    #endregion

    #region Q2) Create a class named Rectangle with the following constructors:
    //●	A parameterless constructor that sets the width and height to 0.
    //●	A constructor that accepts width and height as integers.
    //●	A constructor that accepts a single integer and sets both width and height to that value.
    internal class Rectangle
    {
        private int width, height;
        Rectangle()
        {
            width = 0;
            height = 0;
        }
        Rectangle(int _x, int _y)
        {
            width = _x;
            height = _y;
        }
        Rectangle(int val)
        {
            width = val;
            height = val;
        }
    }
    #endregion

    #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
    //* Note: Overload the +, - operator to add and subtract two complex numbers.	
    internal class ComplexNumber
    {
        public int Real { set; get; }
        public int Img { set; get; }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber
            {
                Real = c1.Real + c2.Real,
                Img = c1.Img + c2.Img
            };
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber
            {
                Real = c1.Real - c2.Real,
                Img = c1.Img - c2.Img
            };
        }
    }
    #endregion

    #region Question 4)   
    //a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
    //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
    //  * Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.
    internal class Employee
    {
        public virtual string Work()
        {
            return "Employee is  working";
        }
    }
    internal class Manager : Employee
    {
        public override string Work()
        {
            return "Manager is managing";
        }
    }
    #endregion

    #region Question 5)  
    //a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".  
    //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
    //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
    //Then explain the difference between using override and new (using binding behavior)
    internal class BaseClass
    {
        public virtual string DisplayMessage()
        {
            return "Message from BaseClass";
        }
    }
    internal class DerivedClass1 : BaseClass
    {
        public override string DisplayMessage()
        {
            return "Message from DerivedClass1";
        }
    }
    internal class DerivedClass2 : BaseClass
    {
        public new string DisplayMessage()
        {
            return "Message from DerivedClass2";
        }
    }
    //override : Replaces base class method and it is Dynamic Binding(Run-time)
    //new : Hides base class method and it is Static Binding(Compile-time)
    #endregion

    #region Part02
    /*
    1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
    2-Override All System.Object Members [To String(), Equals(), GetHashCode()] .
    3-Define All Required Constructors to Produce this output:
    Duration D1 = new Duration(1, 10, 15);
        D1.ToString(); 
    Output: Hours: 1, Minutes :10, Seconds :15
    Duration D1 = new Duration(3600);
        D1.ToString(); 
    Output: Hours: 1, Minutes :0, Seconds :0
    Duration D2 = new Duration(7800);
        D2.ToString(); 
    Output: Hours: 2, Minutes :10, Seconds :0
    Duration D3 = new Duration(666);
        D3.ToString(); 
    Output: Minutes :11, Seconds :6
     4-Implement All required Operators overloading to enable this Code:
    ●	D3=D1+D2
    ●	D3=D1 + 7800
    ●	D3=666+D3
    ●	D3= ++D1 (Increase One Minute)
    ●	D3 = --D2 (Decrease One Minute)
    ●	D1= D1 -D2
    ●	If (D1>D2)
    ●	If (D1<=D2)
    ●	If (D1)
    ●	DateTime Obj = (DateTime) D1
    */
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            int remaining = totalSeconds % 3600;
            Minutes = remaining / 60;
            Seconds = remaining % 60;
        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }
        public override bool Equals(object obj)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours + d2.Hours,
                d1.Minutes + d2.Minutes,
                d1.Seconds + d2.Seconds
            );
        }
        public static Duration operator +(Duration d1)
        {
            return new Duration(
                d1.Seconds + 7800
            );
        }
        public static Duration operator ++(Duration d1)
        {
            return new Duration(
                d1.Seconds+60
            );
        }
        public static Duration operator --(Duration d1)
        {
            return new Duration(d1.Hours,
                d1.Minutes-60,
                d1.Seconds
            );
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours - d2.Hours,
                d1.Minutes - d2.Minutes,
                d1.Seconds - d2.Seconds
            );
        }
    }
    #endregion
}
