
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
    }

    public override void Drawer(Object source, PaintEventArgs e)
    {
        photo.Drawer(source, e);
        e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
    }
}