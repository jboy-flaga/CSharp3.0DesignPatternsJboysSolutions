
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
        Application.Run(photo);
        foodTaggedPhoto = new TaggedPhoto(photo, "Food");
        colorTaggedPhoto = new TaggedPhoto(foodTaggedPhoto, "Yellow");
        composition = new BorderedPhoto(colorTaggedPhoto, Color.Blue);
        Application.Run(composition);
        Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());

        // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
        photo = new Photo();
        tag = new TaggedPhoto(photo, "Jug");
        composition = new BorderedPhoto(tag, Color.Yellow);
        Application.Run(composition);
        Console.WriteLine(tag.ListTaggedPhotos());
    }
}
/* Output

TaggedPhotos are: Food Yellow                                                                                                  
TaggedPhotos are: Food Yellow Jug   
*/
