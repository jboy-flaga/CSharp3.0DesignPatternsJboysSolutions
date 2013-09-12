using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise4
{
    // Proxy for FleekerAcount that restricts downloading photos and commenting on photos to friends only
    public class FleekerAccountProxy : IFleekerAccount
    {
        FleekerAccount _fleekerAccount;

        public FleekerAccountProxy(string name)
        {
            this._fleekerAccount = new FleekerAccount(name);
        }

        public int Id
        {
            get { return _fleekerAccount.Id; }
        }

        public string Name
        {
            get
            {
                return _fleekerAccount.Name;
            }
            set
            {
                _fleekerAccount.Name = value;
            }
        }

        public List<Photo> Photos
        {
            get { return _fleekerAccount.Photos; }
        }

        public List<IFleekerAccount> Friends
        {
            get { return _fleekerAccount.Friends; }
        }

        public void AddFriend(IFleekerAccount friend)
        {
            _fleekerAccount.AddFriend(friend);
        }

        public void DownloadPhoto(Photo photo)
        {
            if (_fleekerAccount.Friends.Contains(photo.Owner))
            {
                _fleekerAccount.DownloadPhoto(photo);
            }
            else
            {
                Console.WriteLine("You cannot download this photo because you are not friends with the owner of the photo");
            }
        }

        public void CommentOnPhoto(string comment, Photo photo)
        {
            if (_fleekerAccount.Friends.Contains(photo.Owner))
            {
                _fleekerAccount.CommentOnPhoto(comment, photo);
            }
            else
            {
                Console.WriteLine("You cannot comment on this photo because you are not friends with the owner of the photo");
            }
        }

        public void AddPhoto(Photo photo)
        {
            _fleekerAccount.AddPhoto(photo);
        }
    }
}
