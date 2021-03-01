using System;

namespace VirtualOveride
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Shape objShape = new Shape();
            objShape.draw();

           
            Square objSquare = new Square();
            objSquare.draw();

            Console.ReadKey();
        }
    }

    
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("From base class : Shape");
        }
    }

   
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("From derived class, Method(draw) is overidden : Square");
        }
    }

}



