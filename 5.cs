using System;
using System.Collections.Generic;
class ArrayInterface
{
   static void Main()
{
   int[]a=new int[3];
   a[0]=1;
   a[1]=2;
   a[2]=3;
  Display(a);
  list<int>list=new list<int>();
  list.add(5);
  list.add(7);
  list.add(9);
  Console.ReadLine();
}
static void Display(Ilist<int>list)
{
   Console.WriteLine("Count:{0)",list.Count);
   foreach(int num in Ilist)
   {
      Console.WriteLine(num);
   }
}
}