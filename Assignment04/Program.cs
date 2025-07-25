namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DetermineIfColorisPrimary("Yellow");
        }
        #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
        static void PrintWeekDays()
        {
            Console.WriteLine("Days of the Week :");
            foreach (string day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void DetermineSeasonMonths(string input)
        {
            if (Enum.TryParse(input, true, out Season season))
            {
                if (season == Season.Spring)
                    Console.WriteLine("Spring: March to May");
                else if (season == Season.Summer)
                    Console.WriteLine("Summer: June to August");
                else if (season == Season.Autumn)
                    Console.WriteLine("Autumn: September to November");
                else if (season == Season.Winter)
                    Console.WriteLine("Winter: December to February");
            }
        }
        #endregion

        #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum .Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
        #endregion

        #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void DetermineIfColorisPrimary(string input)
        {
            if (Enum.TryParse(input, true, out Colors color))
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{input} is not a primary color.");
            }
            #endregion
        }
    }
}
