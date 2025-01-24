namespace Assigment
{


    #region First Project
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y) : this(x, y, 0) { }

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


        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return !Equals(left, right);
        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }


        public int CompareTo(Point3D other)
        {
            if (X != other.X)
            {
                return X.CompareTo(other.X);
            }
            return Y.CompareTo(other.Y);
        }
    }
    #endregion


/// <summary>
/// ////////////////////////////////////////////////////////////////////
/// </summary>

    #region Second Project
    public class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)x / y;
        }
    }

    #endregion


    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////
    /// 
    /// </summary>
    /// 


   
    public abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }


    public class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage)
        {
            Name = "Percentage Discount";
            Percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }

    public class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }

        public FlatDiscount(decimal flatAmount)
        {
            Name = "Flat Discount";
            FlatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }

    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }


    public abstract class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }

    public class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    public class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    public class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return null; // No discount for guest users
        }
    }





    internal class Program
    {
        public static void Main()
        {

            #region First Project
            //    Point3D P1 = ReadPoint("P1");
            //    Point3D P2 = ReadPoint("P2");

            //    Console.WriteLine(P1.ToString());
            //    Console.WriteLine(P2.ToString());


            //    if (P1 == P2)
            //    {
            //        Console.WriteLine("P1 and P2 are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("P1 and P2 are not equal.");
            //    }


            //    Point3D[] points = { P1, P2, new Point3D(1, 2, 3), new Point3D(4, 5, 6) };
            //    Array.Sort(points);

            //    Console.WriteLine("Sorted Points:");
            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point.ToString());
            //    }
            //}

            //private static Point3D ReadPoint(string pointName)
            //{
            //    int x, y, z;

            //    Console.WriteLine($"Enter coordinates for {pointName}:");

            //    Console.Write("X: ");
            //    while (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer for X.");
            //    }

            //    Console.Write("Y: ");
            //    while (!int.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer for Y.");
            //    }

            //    Console.Write("Z: ");
            //    while (!int.TryParse(Console.ReadLine(), out z))
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer for Z.");
            //    }

            //    return new Point3D(x, y, z);

            #endregion


            #region Second Project

            //int x = 10;
            //int y = 2;

            //Console.WriteLine($"Add: {Maths.Add(x, y)}");
            //Console.WriteLine($"Subtract: {Maths.Subtract(x, y)}");
            //Console.WriteLine($"Multiply: {Maths.Multiply(x, y)}");
            //Console.WriteLine($"Divide: {Maths.Divide(x, y)}"); 
            #endregion




         
        
                Console.WriteLine("Enter user type (Regular, Premium, Guest):");
                string userType = Console.ReadLine();

                User user;
                switch (userType.ToLower())
                {
                    case "regular":
                        user = new RegularUser { Name = "Regular User" };
                        break;
                    case "premium":
                        user = new PremiumUser { Name = "Premium User" };
                        break;
                    case "guest":
                        user = new GuestUser { Name = "Guest User" };
                        break;
                    default:
                        Console.WriteLine("Invalid user type.");
                        return;
                }

                Console.WriteLine("Enter product price:");
                decimal price;
                while (!decimal.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                }

                Console.WriteLine("Enter product quantity:");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid quantity.");
                }

                Discount discount = user.GetDiscount();
                decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
                decimal finalPrice = (price * quantity) - discountAmount;

                Console.WriteLine($"Total Discount: {discountAmount:C}");
                Console.WriteLine($"Final Price: {finalPrice:C}");
            
        }




    }
}







