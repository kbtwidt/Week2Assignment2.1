using System.Text;

namespace Week2Assignment2._1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int a, b;
            decimal c, d, e;
            float f, g, h;
            int sum;
            decimal sum1;
            float product;

            Console.WriteLine("Choose an option from below:");
            Console.WriteLine("1)Addition of 2 numbers\n2)Addition of 3 numbers\n" +
                "3)Multiplication of 2 numbers\n4)Multiplication of 3 numbers\n0) Exit");
            choice = int.Parse(Console.ReadLine());

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter 1st number: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("\nEnter 2nd number: ");
                        b = int.Parse(Console.ReadLine());

                        sum = Calculations.Add(a, b);
                        Console.WriteLine($"Sum of {a} and {b} is {sum}");
                        break;
                    case 2:
                        Console.Write("Enter 1st number: ");
                        c = decimal.Parse(Console.ReadLine());
                        Console.Write("\nEnter 2nd number: ");
                        d = decimal.Parse(Console.ReadLine());
                        Console.Write("\nEnter 3rd number: ");
                        e = decimal.Parse(Console.ReadLine());

                        sum1 = Calculations.Add(c, d, e);
                        Console.WriteLine($"\nSum of {c}, {d}, and {e} is {sum1}");
                        break;
                    case 3:
                        Console.Write("Enter 1st number: ");
                        f = float.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        g = float.Parse(Console.ReadLine());

                        product = Calculations.Multiply(f, g);
                        Console.WriteLine($"\nProduct of {f} and {g} is {product}");
                        break;
                    case 4:
                        Console.Write("Enter 1st number: ");
                        f = float.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        g = float.Parse(Console.ReadLine());
                        Console.Write("Enter 3rd number: ");
                        h = float.Parse(Console.ReadLine());

                        product = Calculations.Multiply(f, g, h);
                        Console.WriteLine($"\nProduct of {f}, {g}, and {h} is {product}");
                        break;

                    default:
                        Console.WriteLine($"{choice} is not a valid option");
                        break;

                }
                Console.Write("If you would like to choose again, select from the above menu otherwise type 0 to exit: ");
                choice = int.Parse(Console.ReadLine());
            }
        }


    }
}
