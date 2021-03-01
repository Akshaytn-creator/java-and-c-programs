import java.*;
import java.util.Scanner;
public class Sort
{
    public static void main(String args[])
    {
     int n,i,j;
     Scanner sc=new Scanner(System.in);
     System.out.println("Enter number of strings to sort");
     n=sc.nextInt();
     String Sort1[]=new String[n];
     System.out.println("Enter the strings to sort");
     for(i=0;i<n;i++)
     for(i=0;i<n;i++)
     {
       Sort1[i]=sc.next();
     }
 for(i=0;i<Sort1.length;i++)
{
   for(j=i+1;j<Sort1.length;j++)
   {
     if(Sort1[j].compareTo(Sort1[i])<0)
     {
      String temp=Sort1[i];
      Sort1[i]=Sort1[j];
      Sort1[j]=temp; 
     }
   }
 }
System.out.println("sorted array is:");
 for(i=0;i<Sort1.length;i++)
{
System.out.println(Sort1[i]);
}
}
}