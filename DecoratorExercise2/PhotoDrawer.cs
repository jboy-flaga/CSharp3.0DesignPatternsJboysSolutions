using System;
using System.Windows.Forms;

namespace DecoratorExercise
{
    public abstract class PhotoDrawer : Form
    {
        public PhotoDrawer()
        {
            this.Paint += new PaintEventHandler(Drawer);
        }

        public abstract void Drawer(Object source, PaintEventArgs e);
    }
}
