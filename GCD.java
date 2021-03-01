import java.util.Scanner;
import java.lang.*;
class GCD
{
   int gcd(int i,int j)
   {
     if(j==0)
      return i;
    else if(i<j)
    return gcd(j,i);
   else
  return gcd(j,i%j);
  }
 public static void main(String args[])
 {
    Scanner sc=new Scanner(System.in);
   System.out.println("enter the value of a");
   int a=sc.nextInt();
   System.out.println("enter the value of b");
   int b=sc.nextInt();
    GCD obj1=new GCD();
   int res=obj1.gcd(a,b);
  System.out.println("the gcd of a and b is"+res);
}
}