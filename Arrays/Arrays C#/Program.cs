using System.Collections;

namespace Arrays_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# Array Declaration 

            int[] n = new int[10];
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            Console.WriteLine("Old Value at index 2: " + n[2]); // Access Array Elements

            n[2] = 200;
            Console.WriteLine("New Value at index 2: " + n[2]);// change the value at index 2

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            

            //initializing 2D array
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            // create a jagged array
            int[][] jaggedArray = {
            new int[] {1, 3, 5},
            new int[] {2, 4},
            };

            // print elements of jagged array
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);

            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string k in cars)
            {
                Console.WriteLine(k);
            }
            Array.Sort(cars);
            Console.WriteLine("Sorted:");
            foreach (string z in cars)
            {
                Console.WriteLine(z);
            }

            //dynamic arrays in C#

            ArrayList al = new ArrayList();

            al.Add(577);
            al.Add(286);

            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("List: ");
            foreach (int g in al)
            {
                Console.Write(g + " ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // user input
            int[] array = new int[5];
            for(int p=0; p<5; p++)
            {
                Console.WriteLine("Enter number : ");
                array[p]= Convert.ToInt32(Console.ReadLine());

            }
            for(int q=0; q<5; q++)
            {
                Console.WriteLine("Index [{0}] = {1}",q,array[q]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // user input
            int[,] array1 = new int[2, 2];
            for (int p = 0; p < 2; p++)
            {

                for(int q = 0; q < 2; q++)
                {
                    Console.WriteLine("Enter number : ");
                    array1[p, q] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int l = 0; l < 2; l++)
            {
                for (int r = 0; r < 2; r++)
                {
                    Console.WriteLine("Index [{0}, {1}] = {2}", l,r, array1[l, r]);
                }
                
            }
        }
    }
}
