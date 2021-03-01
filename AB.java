import java.applet.Applet;
import java.awt.*;
public class AB extends Applet
{
   public void paint(Graphics g)
   {
     g.drawRect(20,30,50,100);
     g.drawOval(20,150,50,50);
     g.drawOval(20,220,100,50);
     g.drawLine(20,300,100,300);
   }
}
     