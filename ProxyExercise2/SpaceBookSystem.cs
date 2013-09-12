using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise2
{
    public class SpaceBookSystem
    {
        // The Subject
        private class SpaceBook
        {
            static SortedList<string, SpaceBook> community =
                  new SortedList<string, SpaceBook>(100);
            string pages;
            string name;
            string gap = "\n\t\t\t\t";

            static public bool IsUnique(string name)
            {
                return community.ContainsKey(name);
            }

            internal SpaceBook(string n)
            {
                name = n;
                community[n] = this;
            }

            internal void Add(string s)
            {
                pages += gap + s;
                Console.Write(gap + "======== " + name + "'s SpaceBook =========");
                Console.Write(pages);
                Console.WriteLine(gap + "===================================");
            }

            internal void Add(string friend, string message)
            {
                if (community.ContainsKey(friend))
                    community[friend].Add(message);
            }

            internal void Poke(string who, string friend)
            {
                if (community.ContainsKey(who))
                    community[who].pages += gap + friend + " poked you";
            }
        }

        // The Proxy
        public class MySpaceBook
        {
            // Combination of a virtual and authentication proxy
            SpaceBook mySpaceBook;
            string password;
            bool loggedIn = false;

            public string Name { get; set; }

            void Register()
            {
                Console.WriteLine("Let's register you for SpaceBook");
                do
                {
                    Console.WriteLine("All SpaceBook names must be unique");
                    Console.Write("Type in a user name: ");
                    Name = Console.ReadLine();
                } while (SpaceBook.IsUnique(Name));
                Console.Write("Type in a password: ");
                password = Console.ReadLine();
                Console.WriteLine("Thanks for registering with SpaceBook");
            }

            bool Authenticate()
            {
                Console.Write("Welcome " + Name + ". Please type in your password: ");
                string supplied = Console.ReadLine();
                if (supplied == password)
                {
                    loggedIn = true;
                    Console.WriteLine("Logged into SpaceBook");
                    if (mySpaceBook == null)
                        mySpaceBook = new SpaceBook(Name);
                    return true;
                }
                Console.WriteLine("Incorrect password");
                return false;
            }

            public void Add(string message)
            {
                Check();
                if (loggedIn) mySpaceBook.Add(message);
            }

            public void Add(string friend, string message)
            {
                Check();
                if (loggedIn)
                    mySpaceBook.Add(friend, Name + " said: " + message);
            }

            public void Poke(string who)
            {
                Check();
                if (loggedIn)
                    mySpaceBook.Poke(who, Name);
            }

            void Check()
            {
                if (!loggedIn)
                    if (password == null)
                        Register();
                if (mySpaceBook == null)
                    Authenticate();
            }
        }
    }
}
