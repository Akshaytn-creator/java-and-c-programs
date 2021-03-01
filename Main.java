import java.lang.*;
import java.util.*;
interface i1
{
    void tdisplay();
}
   interface i2
{
   void rdisplay();
}
class area implements i1,i2
{
   public void tdisplay()
   {
     System.out.println("enter the value of base and height");
     Scanner sc=new Scanner(System.in);
     float base,height;
     base=sc.nextFloat();
     height=sc.nextFloat();
    System.out.println("the area of triangle="+(0.5*base*height));
  }
public void rdisplay()
{
   System.out.println("enter value of height and breadth");
   Scanner sc=new Scanner(System.in);
   float length,breadth;
   length=sc.nextFloat();
   breadth=sc.nextFloat();
   System.out.println("the area of rectangle ="+(length*breadth));
}
}
  class Main
{
   public static void main(String args[])
  {
    area obj=new area();
    obj.tdisplay();
    obj.rdisplay();
  }
}