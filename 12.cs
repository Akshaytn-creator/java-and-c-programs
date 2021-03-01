using System;
using System.Collections.Generic;

class GFG
{
   
    static public void Main()
    {
         
        LinkedList<String> my_list = new LinkedList<String>();

        Console.WriteLine("Enter how many Students:");
        int nodes =Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("\n Enter " + nodes + " Student name");
        for (int i = 0; i < nodes; i++)
        {
             my_list.AddLast(Console.ReadLine());
        }

        Console.WriteLine("Students are:");

       
        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
        Console.ReadKey();
    }
}
