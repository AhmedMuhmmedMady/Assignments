namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Maths.Add(10, 30));
        }
    }
    #region First Project
    internal class Point3D : ICloneable, IComparable<Point3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() { }

        public Point3D(int x)
        {
            X = x;
            Y = 0;
            Z = 0;
        }
        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        public int CompareTo(Point3D other)
        {
            if (this.X != other.X)
                return this.X.CompareTo(other.X);
            else
                return this.Y.CompareTo(other.Y);
        }
    }
    #endregion

    #region Second Project
    public static class Maths
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Subtract(int a, int b) { return a - b; }
        public static int Multiply(int a, int b) { return a * b; }
        public static double Divide(int a, int b) { return (double)a / (double)b; }
    }
    #endregion

    #region Third Project

    // Part 1: Abstract Discount Class
    public abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }


    // Part 2: Specific Discounts
    public class PercentageDiscount : Discount
    {
        private decimal percentage;
        public PercentageDiscount(decimal percent)
        {
            percentage = percent;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }

    public class FlatDiscount : Discount
    {
        private decimal flatAmount;
        public FlatDiscount(decimal amount)
        {
            flatAmount = amount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }

    public class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }


    // Part 3: User Classes
    public abstract class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }

    public class RegularUser : User
    {
        public RegularUser(string name)
        {
            Name = name;
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    public class PremiumUser : User
    {
        public PremiumUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    public class GuestUser : User
    {
        public GuestUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }
    #endregion
}
