namespace Variables_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "piyush";
            Console.WriteLine(name);

            int n = 15;
            Console.WriteLine(n);

            int a;
            a = 50;
            Console.WriteLine(a);

            char c = 'a';
            Console.WriteLine(c);

            bool b = true;
            Console.WriteLine(b);

            double num = 55.555;
            Console.WriteLine(num);

            uint ui = 100u;
            Console.WriteLine(ui);

            float fl = 10.2f;
            Console.WriteLine(fl);

            long l = 45755452222222L; 
            Console.WriteLine(l);

            ulong ul = 88755452222222UL; 
            Console.WriteLine(ul);

            ushort us1 = 65535;
            Console.WriteLine(us1);

            decimal mon = 1000.15m;
            Console.WriteLine(mon);

            byte bb = 125;
            Console.WriteLine(bb);

            sbyte sb1 = -128;
            Console.WriteLine(sb1);

            DateTime dt = new DateTime(2015, 12, 31);
            Console.WriteLine(dt);
            Console.WriteLine();


            //Implicit Casting

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine("--Implicit Casting--");
            Console.WriteLine("Int: " + myInt);      
            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine();

            //Explicit Casting

            double myDob = 9.78;
            int lint = (int)myDouble;
            Console.WriteLine("--Explicit Casting--");
            Console.WriteLine("Double: "+myDob);   
            Console.WriteLine("Int: "+lint);
        }
    }
}
