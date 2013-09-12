using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- FLEEKER ACCOUNT--- ");
            Console.WriteLine();
            IFleekerAccount me = new FleekerAccount("Jboy");
            Photo mesPhoto1 = new Photo("jboy's photo 1");
            me.AddPhoto(mesPhoto1);

            IFleekerAccount you = new FleekerAccount("NotJboy");
            you.CommentOnPhoto("this is my comment on your photo", mesPhoto1);

            me.AddFriend(you);


            Console.WriteLine();
            Console.WriteLine("--- FLEEKER ACCOUNT  PROXY--- ");
            Console.WriteLine();

            IFleekerAccount jboy = new FleekerAccountProxy("Jboy");
            Photo jboysPhoto1 = new Photo("jboy's photo 1");
            jboy.AddPhoto(jboysPhoto1);

            IFleekerAccount notJboy = new FleekerAccountProxy("NotJboy");
            notJboy.CommentOnPhoto("this is my comment on your photo", jboysPhoto1);
            notJboy.DownloadPhoto(jboysPhoto1);

            jboy.AddFriend(notJboy);
            notJboy.CommentOnPhoto("this is my comment on your photo", jboysPhoto1);
            notJboy.DownloadPhoto(jboysPhoto1);

            Console.ReadLine();
        }
    }
}
