
using DecoratorExercise;
using Given;
using System;
using System.Drawing;
using System.Windows.Forms;

class DecoratorPatternExample
{
    static void Main()
    {
        // Application.Run acts as a simple client
        Hominid hominid;
        TaggedPhoto foodTaggedHominid, colorTaggedHominid, tag;
        BorderedPhoto composition;

        // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
        hominid = new Hominid();
        Application.Run(hominid);
        foodTaggedHominid = new TaggedPhoto(hominid, "Hominid 1");
        colorTaggedHominid = new TaggedPhoto(foodTaggedHominid, "Blue");
        composition = new BorderedPhoto(colorTaggedHominid, Color.Blue);
        Application.Run(composition);
        Console.WriteLine(colorTaggedHominid.ListTaggedPhotos());

        // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
        hominid = new Hominid();
        tag = new TaggedPhoto(hominid, "Hominid 2");
        composition = new BorderedPhoto(tag, Color.Yellow);
        Application.Run(composition);
        Console.WriteLine(tag.ListTaggedPhotos());
    }
}