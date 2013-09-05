
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
        Photo photo;
        TaggedPhoto foodTaggedPhoto, colorTaggedPhoto, tag;
        BorderedPhoto composition;

        // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
        photo = new Photo();
        foodTaggedPhoto = new TaggedPhoto(photo, "Food");
        colorTaggedPhoto = new TaggedPhoto(foodTaggedPhoto, "Yellow");
        Application.Run(colorTaggedPhoto);
        Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());

        // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
        photo = new Photo();
        composition = new BorderedPhoto(photo, Color.Yellow);
        Application.Run(composition);

        // Compose a Hominid with one TaggedPhoto hominid and a yellow BorderedPhoto hominid
        var hominid = new Hominid();
        tag = new TaggedPhoto(hominid, "Shocked!");
        Application.Run(tag);
        Console.WriteLine(tag.ListTaggedPhotos());
    }
}