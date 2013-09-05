using DecoratorExercise;
using System;
using System.Drawing;
using System.Windows.Forms;

class Hominid : PhotoDrawer
{
    Image photo;
    public Hominid()
    {
        photo = new Bitmap(100, 100);
        this.Text = "Hominid";
    }

    public override void Drawer(Object source, PaintEventArgs e)
    {
        //face
        e.Graphics.DrawEllipse(new Pen(Color.SandyBrown, 10), 32, 22, 200, 210);
        //eyes
        e.Graphics.DrawEllipse(new Pen(Color.SandyBrown, 10), 80, 80, 25, 25);
        e.Graphics.DrawEllipse(new Pen(Color.SandyBrown, 10), 168, 80, 25, 25);
        //mouth
        e.Graphics.DrawEllipse(new Pen(Color.SandyBrown, 10), 100, 150, 70, 40);
    }
}