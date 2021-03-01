import java.*;
class Dabc
{
void add(int a,int b);
{
System.out.println("the sum is="+(a+b));
}
void add(float a,float b);
{
System.out.println("the sum is="+(a+b));
}
void add(float a,float b,float c );
{
System.out.println("the sum is="+(a+b+c));
}
public static void main(String args[])
{
Dabc obj=new Dabc();
obj.add(1,2);
obj.add(2.3f,3.2f);
obj.add(2.4f,7.2f,4.3f);
}
} 