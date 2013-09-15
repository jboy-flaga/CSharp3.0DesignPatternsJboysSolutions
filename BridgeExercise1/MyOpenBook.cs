using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExercise1
{
    public partial class SpaceBookSystem
    {
        // A Proxy with little to do
        // Illustrates an alternative implementation in the Bridge pattern
        public class MyOpenBook : Bridge
        {
            // Combination of a virtual and authentication proxy
            SpaceBook spaceBook;
            string name;
            static int users;
            string gap = "\n\t\t";

            public MyOpenBook(string n)
            {
                name = n;
                users++;
                spaceBook = new SpaceBook(name + "-" + users);
            }

            //--------------------------------ADDED
            public MyOpenBook(string n, string header, string footer)
                : this(n)
            {
                spaceBook.Header = gap + header;
                spaceBook.Footer = gap + footer;
            }
            //----------------------------------------------------------

            public void Add(string message)
            {
                spaceBook.Add(message);
            }

            public void Add(string friend, string message)
            {
                spaceBook.Add(friend, name + " : " + message);
            }

            public void Poke(string who)
            {
                spaceBook.Poke(who, name);
            }

            //------------------------------ADDED
            public string Header
            {
                get
                {
                    return spaceBook.Header;
                }
                set
                {
                    spaceBook.Header = value;
                }
            }

            public string Footer
            {
                get
                {
                    return spaceBook.Footer;
                }
                set
                {
                    spaceBook.Footer = value;
                }
            }
            //--------------------------------------------------
        }
    }
}
