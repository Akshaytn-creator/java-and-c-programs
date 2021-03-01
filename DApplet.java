import java.applet.Applet;
import java.awt.*;
public class DApplet extends Applet
{
    public void paint(Graphics g)
    {
    g.setColor(Color.RED);
    g.fillRect(20,30,50,100);
    g.setColor(Color.BLUE);
    g.fillOval(20,150,50,50);
    g.setColor(Color.YELLOW);
    g.fillOval(20,220,100,50);
    g.setColor(Color.GREEN);
    g.drawLine(20,300,100,300);
    }
}
      

  