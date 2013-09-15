using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Portal me = new Portal(new SpaceBookSystem.MyOpenBook("Judith", "++++++++ Judith's OpenBook ++++++++", "+++++++++++++++++++++++++++++++++++"));
            me.Add("Hello world");
            me.Add("Today I worked 18 hours");

            Portal tom = new Portal(new SpaceBookSystem.MyOpenBook("Tom"));
            tom.Poke("Judith-1");
            tom.SuperPoke("Judith-1", "hugged");
            tom.Add("Judith-1", "Poor you");
            tom.Add("Hey, I'm on OpenBook - it was so easy!");


            Portal portal = new Portal(new SpaceBookSystem.MySpaceBook());
            portal.Add("Hi");
            Console.ReadLine();
        }
    }
}
