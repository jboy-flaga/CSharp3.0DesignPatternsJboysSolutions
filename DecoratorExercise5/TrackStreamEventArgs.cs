using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise5
{
    public class TrackStreamEventArgs : EventArgs
    {
        public string Message { get; set; }
        public int PercentRead { get; set; }

        public TrackStreamEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
