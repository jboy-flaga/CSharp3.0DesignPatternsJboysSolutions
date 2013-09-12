using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLoggingFileStream loggingFileStream = new MyLoggingFileStream("mainfile.txt", FileMode.OpenOrCreate, "log.txt");
            loggingFileStream.Write(System.Text.Encoding.ASCII.GetBytes("asdf"), 0, 4);
            loggingFileStream.Flush();
            loggingFileStream.SetLength(100);
            Console.WriteLine("View the Log.txt file...");

            Console.ReadLine();
        }
    }
}
