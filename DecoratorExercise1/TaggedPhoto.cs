
// The TaggedPhoto decorator keeps track of the tag number which gives it 
// a specific place to be written
using DecoratorExercise;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
class TaggedPhoto : PhotoDrawer
{
    PhotoDrawer photo;
    string tag;
    int number;
    static int count;
    List<string> tags = new List<string>();

    public TaggedPhoto(PhotoDrawer p, string t)
    {
        photo = p;
        tag = t;
        tags.Add(t);
        number = ++count;
    }

    public override void Drawer(Object source, PaintEventArgs e)
    {
        photo.Drawer(source, e);
        e.Graphics.DrawString(tag,
        new Font("Arial", 16),
        new SolidBrush(Color.Black),
        new PointF(80, 100 + number * 20));
    }

    public string ListTaggedPhotos()
    {
        string s = "Tags are: ";
        foreach (string t in tags) s += t + " ";
        return s;
    }
}