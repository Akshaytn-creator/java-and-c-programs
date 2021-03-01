import java.applet.Applet;
import java.awt.*;
public class DFont extends Applet
{
    public void paint(Graphics g)
    {
      Font f=new Font("TimesRoman",Font.ITALIC,36);
      g.setFont(f);
      g.setColor(Color.RED);
      g.drawString("2nd Applet program",50,30);
    }
}
