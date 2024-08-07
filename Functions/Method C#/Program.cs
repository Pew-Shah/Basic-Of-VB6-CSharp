namespace Method_C_
{
    internal class Program
    {
        // Method to display the multiplication table of a given number
        static void table(int x)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " * " + i + " = " + x * i);
            }
        }

        // Method to add two integers and display the result
        static void Add(int m, int n)
        {
            int q = m + n;
            Console.WriteLine(q);
            Console.WriteLine("Sum of integers: " + q);
        }

        // Method with a default parameter value
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
            Console.WriteLine();
        }

        // Method Overloading: Adding two integers
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        // Method Overloading: Adding two doubles
        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter integer for multiplication table: ");
            a = Convert.ToInt32(Console.ReadLine());
            table(a);

            int b;
            Console.Write("Enter 1st integer: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.Write("Enter 2nd integer: ");
            c = Convert.ToInt32(Console.ReadLine());

            Add(b, c);

            // Calling MyMethod with different arguments
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod(); // Uses default parameter value

            // Using method overloading
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
