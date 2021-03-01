import java.util.*;
class Calculator
{
   public static void main(String args[])
  {
    System.out.println("Enter 2 values");
    Scanner sc=new Scanner(System.in);
    int a=sc.nextInt();
    int b=sc.nextInt();
    System.out.println("Enter your choice(+,-,*,/,):");
    char ch=sc.next().charAt(0);
    int c=0;
  switch(ch)
{
    case '+': c=a+b;
    break;
    case '-': c=a-b;
    break;
    case '*': c=a*b;
    break;
    case '/': c=a/b;
   

   
}
  System.out.println("value:"+c);
}
}