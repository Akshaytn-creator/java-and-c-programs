using System;

namespace AbstractClsMthd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first and second values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            
            MathsOprtion objMathsOprtion = new MathsOprtion();
            Console.WriteLine("sum = {0}", objMathsOprtion.addition(a, b));
            Console.WriteLine("substraction = {0}", objMathsOprtion.substraction(a, b));

            Console.ReadKey();
        }
    }

    
    abstract class Arithmatic
    {
        
        public abstract int addition(int a, int b);

       
        public int substraction(int a, int b)
        {
            return a - b;
        }
    }

   
    class MathsOprtion : Arithmatic
    {
        public override int addition(int a, int b)
        {
            return a + b;
        }
    }
}




