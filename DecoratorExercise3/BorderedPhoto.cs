
// This simple BorderedPhoto decorator adds a colored BorderedPhoto of fixed size
using DecoratorExercise;
using System;
using System.Drawing;
using System.Windows.Forms;
class BorderedPhoto : PhotoDrawer
{
    PhotoDrawer photo;
    Color color;

    public BorderedPhoto(PhotoDrawer p, Color c)
    {
        photo = p;
        color = c;
        this.Text = "Click Me";
        this.Click += new EventHandler(BorderedPhoto_Click);
    }

    public override void Drawer(Object source, PaintEventArgs e)
    {
        photo.Drawer(source, e);
    }

    void BorderedPhoto_Click(object sender, EventArgs e)
    {
        Graphics g = this.CreateGraphics();
        g.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
    }
}