using System;
using System.Drawing;
using System.Windows.Forms;
using DecoratorExercise;

namespace Given
{
    // The original Photo class
    public class Photo : PhotoDrawer
    {
        Image image;
        public Photo()
        {
            image = new Bitmap("jug.jpg");
            this.Text = "Lemonade";
        }

        public override void Drawer(Object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 30, 20);
        }
    }
}
