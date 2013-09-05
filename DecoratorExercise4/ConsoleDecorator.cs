using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise4
{

    class ConsoleDecorator : TextWriter
    {
        TextWriter _writer;
        public ConsoleDecorator(TextWriter writer)
        {
            this._writer = writer;
        }

        public override void WriteLine()
        {
            _writer.WriteLine();
        }

        public override void WriteLine(string s)
        {
            string[] splitString = s.Split();
            int nCharsDisplayed = 0;
            for (int i = 0; i < splitString.Length; i++)
            {
                nCharsDisplayed += splitString[i].Length;

                if (nCharsDisplayed <= Console.WindowWidth)
                {
                    _writer.Write(splitString[i]);
                }
                else
                {
                    if (Console.CursorLeft != 0) // if cursor is not on first column after the top row is filled
                        _writer.WriteLine();
                    nCharsDisplayed = splitString[i].Length;
                    _writer.Write(splitString[i]);
                }

                if (Console.CursorLeft != 0)
                {
                    _writer.Write(" ");
                    nCharsDisplayed += " ".Length;
                }
            }

            _writer.WriteLine();
        }

        public override void WriteLine(string s, params object[] arg)
        {
            StringWriter strWriter = new StringWriter();
            strWriter.Write(s, arg);

            string[] splitString = strWriter.ToString().Split();

            int nCharsDisplayed = 0;
            for (int i = 0; i < splitString.Length; i++)
            {
                nCharsDisplayed += splitString[i].Length;

                if (nCharsDisplayed <= Console.WindowWidth)
                {
                    _writer.Write(splitString[i]);
                }
                else
                {
                    if (Console.CursorLeft != 0) // if cursor is not on first column after the top row is filled
                        _writer.WriteLine();
                    nCharsDisplayed = splitString[i].Length;
                    _writer.Write(splitString[i]);
                }

                if (Console.CursorLeft != 0)
                {
                    _writer.Write(" ");
                    nCharsDisplayed += " ".Length;
                }
            }

            _writer.WriteLine();
        }

        public override Encoding Encoding
        {
            get { return this._writer.Encoding; }
        }
    }
}
