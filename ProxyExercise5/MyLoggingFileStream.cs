using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExercise5
{

    public class MyLoggingFileStream : Stream
    {
        FileStream _fileStream;
        FileStream _logFile;

        public MyLoggingFileStream(string filename, FileMode filemode, string logFile)
        {
            this._fileStream = new FileStream(filename, filemode);
            this._logFile = new FileStream(logFile, FileMode.OpenOrCreate);
        }

        public override bool CanRead
        {
            get { return _fileStream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _fileStream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _fileStream.CanWrite; }
        }

        public override void Flush()
        {
            string s = DateTime.Now + " - Calling Flush()\n";
            _logFile.Write(System.Text.Encoding.ASCII.GetBytes(s), 0, s.Length);
            _fileStream.Flush();
        }

        public override long Length
        {
            get { return _fileStream.Length; }
        }

        public override long Position
        {
            get
            {
                return _fileStream.Position;
            }
            set
            {
                _fileStream.Position = value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            string log = DateTime.Now + " - Calling Read()\n";
            _logFile.Write(System.Text.Encoding.ASCII.GetBytes(log), 0, log.Length);
            return _fileStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            string log = DateTime.Now + " - Calling Seek()\n";
            _logFile.Write(System.Text.Encoding.ASCII.GetBytes(log), 0, log.Length);
            return _fileStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            string log = DateTime.Now + " - Calling SetLength()\n";
            _logFile.Write(System.Text.Encoding.ASCII.GetBytes(log), 0, log.Length);
            _fileStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            string log = DateTime.Now + " - Calling Write()\n";
            _logFile.Write(System.Text.Encoding.ASCII.GetBytes(log), 0, log.Length);
            _fileStream.Write(buffer, offset, count);
        }
    }
}
