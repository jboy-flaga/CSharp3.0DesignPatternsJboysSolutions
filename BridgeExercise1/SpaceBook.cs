using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExercise1
{
    public partial class SpaceBookSystem
    {
        // The Subject
        private class SpaceBook
        {
            static SortedList<string, SpaceBook> community =
                new SortedList<string, SpaceBook>(100);
            string pages;
            string name;
            string gap = "\n\t\t";

            //----------------------ADDED
            public string Header { get; set; }
            public string Footer { get; set; }
            //----------------------------------------------------

            static public bool IsUnique(string name)
            {
                return community.ContainsKey(name);
            }

            internal SpaceBook(string n)
            {
                name = n;
                community[n] = this;

                //--------------------ADDED
                //default header and footer
                this.Header = gap + "======== " + name + "'s SpaceBook =========";
                this.Footer = gap + "================================";
                //------------------------------------------------------------
            }

            //-----------------------------------------ADDED
            internal SpaceBook(string n, string header, string footer)
                : this(n)
            {
                //default header and footer
                this.Header = gap + header;
                this.Footer = gap + footer;
            }
            //------------------------------------------------------------

            internal void Add(string s)
            {
                pages += gap + s;
                Console.WriteLine(this.Header +
                          pages + "\n" +
                        this.Footer);

            }

            internal void Add(string friend, string message)
            {
                community[friend].Add(message);
            }

            internal void Poke(string who, string friend)
            {
                community[who].pages += gap + friend + " poked you";
            }
        }
    }
}
