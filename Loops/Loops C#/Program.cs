namespace Loops_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for loop
            Console.WriteLine("FOR LOOP :");
            for (int k = 1; k <=4; k++)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();


            // nested for loop
            Console.WriteLine("NESTED FOR LOOP :");
            for (int c = 1; c <= 2; c++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(c + " " + j);
                }
            }
            Console.WriteLine();

            // while loop
            Console.WriteLine("WHILE LOOP :");
            int i = 1;
            Console.WriteLine("First 5 Natural Numbers are: ");
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            // do while loop
            Console.WriteLine("DO-WHILE LOOP :");
            int a = 1;
            Console.WriteLine("Natural Numbers are: ");
            do
            {
                Console.WriteLine(i);
                a++;
            } while (a <= 7);

            Console.WriteLine();

            // foreach loop
            Console.WriteLine("FOREACH LOOP :");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string z in cars)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine();


            //Loop Control Statements

            //break
            Console.WriteLine("break :");
            for (int b = 0; b < 10; b++)
            {
                if (b == 4)
                {
                    break;
                }
                Console.WriteLine(b);
            }
            Console.WriteLine();

            // continue
            Console.WriteLine("continue :");
            for (int m = 0; m < 10; m++)
            {
                if (m % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(m);
            }

        }
    }
}
