namespace Conditional_Statements_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if condition: 
            Console.WriteLine("------------------------if------------------------");
            int a = 10;
            int b = 10;
            if (a == b)
            {
                Console.WriteLine("Both a and b are equal");

            }
            Console.WriteLine();

            //if-else condition:
            Console.WriteLine("------------------------if-else------------------------");
            int c = 11;
            int d = 10;
            if (c == d)
            {
                Console.WriteLine("Both c and d are equal");
            }
            else
            {
                Console.WriteLine("Both c and d are not equal");
            }
            Console.WriteLine();


            //if-elseif condition:
            Console.WriteLine("------------------------if-elseif------------------------");
            int input = 11;
            if (input < 0)
            {
                Console.WriteLine("Input value is a negative integer");
            }
            else if (input == 0)
            {
                Console.WriteLine("Input value is zero");
            }
            else if (input > 0)
            {
                Console.WriteLine("The input value is a positive integer");
            }
            Console.WriteLine();



            //nested-if:
            Console.WriteLine("------------------------nested-if------------------------");
            int i = 30;
            if (i > 10)
            {
                if (i == 20)
                {
                    Console.WriteLine("The value of the integer is 20");
                }
                else
                {
                    Console.WriteLine("The value of the integer is not 20");
                }
            }
            else
            {
                Console.WriteLine("The value of integer is not greater than 10");
            }
            Console.WriteLine();



            //switch:
            Console.WriteLine("------------------------Switch------------------------");
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.WriteLine();

            //nested-switch
            Console.WriteLine("------------------------nested-switch------------------------");
            string fruit = "Apple";
            string color = "Red";

            switch (fruit)
            {
                case "Apple":
                    switch (color)
                    {
                        case "Red":
                            Console.WriteLine("The fruit is a Red Apple.");
                            break;
                        case "Green":
                            Console.WriteLine("The fruit is a Green Apple.");
                            break;
                        default:
                            Console.WriteLine("The fruit is an Apple with an unknown color.");
                            break;
                    }
                    break;

                case "Banana":
                    switch (color)
                    {
                        case "Yellow":
                            Console.WriteLine("The fruit is a Yellow Banana.");
                            break;
                        default:
                            Console.WriteLine("The fruit is a Banana with an unknown color.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Unknown fruit.");
                    break;
            }
        
    }
    }
}
