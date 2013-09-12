using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise4
{
    public class Photo
    {
        public Photo(string photoName)
        {
            this.PhotoName = photoName;
            this.Comments = new List<string>();
        }

        public string PhotoName { get; set; }
        public FleekerAccount Owner { get; set; }
        public List<string> Comments { get; private set; }
    }
}
