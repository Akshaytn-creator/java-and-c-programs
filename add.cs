using System;

namespace SDC
{
    class cmdLnArgs
    {
        static void Main(string[] args)
        {
            int oprnd1, oprnd2;

            oprnd1 = Convert.ToInt32(args[0]);
            oprnd2 = Convert.ToInt32(args[1]);

            Console.WriteLine("Sum = " + (oprnd1 + oprnd2));
            Console.ReadKey();
        }
    }
}

