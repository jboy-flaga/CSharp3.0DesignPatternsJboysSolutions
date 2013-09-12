using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceBookSystem.MySpaceBook me = new SpaceBookSystem.MySpaceBook();
            
            me.Add("Hello world");
            me.Add("Today I worked 18 hours");

            SpaceBookSystem.MySpaceBook tom = new SpaceBookSystem.MySpaceBook();
            tom.Poke(me.Name);
            tom.Add(me.Name, "Poor you");
            tom.Add("Off to see the Lion King tonight");

            tom.AddAsFriend(me.Name);
            tom.Poke(me.Name);
            tom.Add(me.Name, "Poor you again");
            tom.Add("Off to see the Lion King tonight again");

            tom.AddAsFriend("Judith");

            Console.ReadLine();
        }
    }
}
