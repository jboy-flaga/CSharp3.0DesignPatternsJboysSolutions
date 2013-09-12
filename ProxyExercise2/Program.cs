using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceBookSystem.MySpaceBook me = new SpaceBookSystem.MySpaceBook();
            MySpaceBookDecorator meDecorator = new MySpaceBookDecorator(me);
            meDecorator.Add("Hello world");
            meDecorator.Add("Today I worked 18 hours");

            SpaceBookSystem.MySpaceBook tom = new SpaceBookSystem.MySpaceBook();
            MySpaceBookDecorator tomsDecorator = new MySpaceBookDecorator(tom);
            tomsDecorator.Poke(me.Name);
            tomsDecorator.Add("me.Name", "Poor you");
            //tom.Add("Off to see the Lion King tonight");

            Console.ReadLine();
        }
    }
}
