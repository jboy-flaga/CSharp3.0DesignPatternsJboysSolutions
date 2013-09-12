using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise2
{
    public class MySpaceBookDecorator : SpaceBookSystem.MySpaceBook
    {
        SpaceBookSystem.MySpaceBook _mySpaceBook;

        public MySpaceBookDecorator(SpaceBookSystem.MySpaceBook mySpaceBook)
        {
            this._mySpaceBook = mySpaceBook;
        }

        public new void Add(string message)
        {

            Console.WriteLine("\n########## (Decorator) RENDERING USER'S CUSTOM BACKGROUND ##########\n");
            _mySpaceBook.Add(message);
            Console.WriteLine("\n########## ########## ########## ########## ########## ########## ##\n");
        }

        public new void Add(string friend, string message)
        {
            Console.WriteLine("\n########## (Decorator) RENDERING USER'S CUSTOM BACKGROUND ##########\n");
            _mySpaceBook.Add(friend, message);
            Console.WriteLine("\n########## ########## ########## ########## ########## ########## ##\n");
        }

        public void Poke(string who)
        {
            Console.WriteLine("\n########## (Decorator) RENDERING USER'S CUSTOM BACKGROUND ##########\n");
            _mySpaceBook.Poke(who);
            Console.WriteLine("\n########## ########## ########## ########## ########## ########## ##\n");
        }
    }
}
