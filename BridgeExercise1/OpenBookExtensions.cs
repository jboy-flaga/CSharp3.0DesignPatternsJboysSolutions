using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExercise1
{
    static class OpenBookExtensions
    {
        public static void SuperPoke(this Portal me, string who, string what)
        {
            me.Add(who, what + " you");
        }
    }
}
