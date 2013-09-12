using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyExercise4
{
    public interface IFleekerAccount
    {
        int Id { get; }
        string Name { get; set; }
        List<Photo> Photos { get; }
        List<IFleekerAccount> Friends { get; }

        void AddFriend(IFleekerAccount friend);
        void DownloadPhoto(Photo photo);
        void CommentOnPhoto(string comment, Photo photo);
        void AddPhoto(Photo photo);
    }
}
