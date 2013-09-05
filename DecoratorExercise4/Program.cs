using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDecorator writer = new ConsoleDecorator(Console.Out);
            writer.WriteLine("asdf asdf asdhfghf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf ");
            writer.WriteLine();
            writer.WriteLine("afdfasdsdf asdf asdhfghf asdf asdf asdf asdf asdf asdf asdf artwerewrsdf asdf asdf asdf asdf asdf asdf tyrdfgasdf asdf asdf asdf asdf asdf asdf ");
            writer.WriteLine();
            writer.WriteLine("{0} asdf {1} asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf asdf ", 1234567, "Jeriboy");
            writer.WriteLine();
            writer.WriteLine("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz");
            Console.ReadLine();
        }
    }
}
