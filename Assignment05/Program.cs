namespace PersonStructExample
{
    class Program
    {
        static void Main()
        {
            //Point point1 = new Point(20, 30);
            //Point point2 = new Point(40, 50);
            //Console.WriteLine(CalculateDistance(point1, point2));

            //Person[] people = new Person[3];
            //people[0] = new Person("Alice", 88);
            //people[1] = new Person("Bob", 30);
            //people[2] = new Person("Charlie", 22);
            //PrintPersonsData(people); 
            //OldestPerson(people[0], people[1], people[2]);


            Rectangle rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 6;
            DisplayInfo(rectangle);

        }
        #region 1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        static void PrintPersonsData(Person[] people)
        {
            Console.WriteLine("List of Persons:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
        #endregion
        #region 2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        static double CalculateDistance(Point P1, Point P2)
        {
            int dx = P2.X - P1.X;
            int dy = P2.Y - P1.Y;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }
        #endregion
        #region 3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        static void OldestPerson(Person P1, Person P2, Person P3)
        {
            Person oldest = P1;

            if (P2.Age > oldest.Age)
                oldest = P2;
            if (P3.Age > oldest.Age)
                oldest = P3;
            Console.WriteLine($"Name : {oldest.Name} , Age : {oldest.Age}");
        }
        #endregion
        #region 4.Create a struct named Rectangle that represents a rectangle with the following fields: width(type: double)height(type: double)Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).Implement a method DisplayInfo that prints the rectangle's dimensions and area.Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
        struct Rectangle
        {
            private double width;
            private double height;

            public double Width
            {
                get { return width; }
                set
                {
                    if (value >= 0)
                        width = value;
                    else
                        Console.WriteLine("Width cannot be negative.");
                }
            }

            public double Height
            {
                get { return height; }
                set
                {
                    if (value >= 0)
                        height = value;
                    else
                        Console.WriteLine("Height cannot be negative.");
                }
            }

            public double Area
            {
                get { return width * height; }
            }
        }
        static void DisplayInfo(Rectangle rectangle)
        {
            Console.WriteLine($"Width: {rectangle.Width}");
            Console.WriteLine($"Height: {rectangle.Height}");
            Console.WriteLine($"Area: {rectangle.Area}");
        }
        #endregion
    }
}