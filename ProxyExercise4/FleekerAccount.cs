using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise4
{
    public class FleekerAccount : IFleekerAccount
    {
        private static int _currentId = 100;

        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Photo> Photos { get; private set; }
        public List<IFleekerAccount> Friends { get; private set; }

        public FleekerAccount(string name)
        {
            this.Id = _currentId++;
            this.Photos = new List<Photo>();
            this.Friends = new List<IFleekerAccount>();

            this.Name = name;
            Console.WriteLine("Account for '" + this.Name + "' created (ID: " + this.Id + ")");
        }

        public void AddFriend(IFleekerAccount friend)
        {
            if (!this.Friends.Contains(friend))
            {
                this.Friends.Add(friend);
                friend.Friends.Add(this);
            }

            Console.WriteLine(this.Name + " and " + friend.Name + " are now friends");
        }

        public void DownloadPhoto(Photo photo)
        {
            Console.WriteLine("Downloading photo named '" + photo.PhotoName + "'");
        }

        public void CommentOnPhoto(string comment, Photo photo)
        {
            photo.Comments.Add(comment);
            Console.WriteLine(this.Name + " added a comment on " + photo.Owner.Name + "'s photo named '" + photo.PhotoName + "'");
        }

        public void AddPhoto(Photo photo)
        {
            photo.Owner = this;
            this.Photos.Add(photo);
            Console.WriteLine(this.Name + " added new photo named " + photo.PhotoName);
        }
    }
}
