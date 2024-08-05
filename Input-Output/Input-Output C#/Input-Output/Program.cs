namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Output

            Console.WriteLine("----Output----");

            Console.WriteLine();
            Console.WriteLine("WriteLine");
            Console.WriteLine("Prints on ");
            Console.WriteLine("New line");

            Console.WriteLine();
            Console.WriteLine("Write");
            Console.Write("Prints on ");
            Console.Write("Same line");


            //C# Input

            Console.WriteLine();
            Console.WriteLine("----Input----");
            Console.WriteLine();

            string abc;
            Console.Write("Enter a string - ");
            abc = Console.ReadLine();
            Console.WriteLine("You entered: "+ abc);

            Console.WriteLine();
            int xy;
            Console.Write("Enter integer value - ");
            xy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + xy);

            Console.WriteLine();
            double dub;
            Console.Write("Enter double value - ");
            dub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You entered: " + dub);


            //Read() and ReadKey() method
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            int userInput = Console.Read();
            Console.WriteLine("Ascii Value" + userInput);
        }
    }
}
