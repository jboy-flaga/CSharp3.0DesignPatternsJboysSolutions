using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise6
{
    class PasswordProtectedStream : Stream
    {
        private Stream _stream;

        public string Password { get; set; }

        public PasswordProtectedStream(Stream stream)
        {
            this._stream = stream;
        }

        public PasswordProtectedStream(Stream stream, string password)
            : this(stream)
        {
            this.Password = password;
        }

        public override bool CanRead
        {
            get { return _stream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _stream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _stream.CanWrite; }
        }

        public override void Flush()
        {
            _stream.Flush();
        }

        public override long Length
        {
            get { return _stream.Length; }
        }

        public override long Position
        {
            get
            {
                return _stream.Position;
            }
            set
            {
                _stream.Position = value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (this.Password == null)
            {
                throw new Exception("Password in PasswordProtectedStream cannot be null");
            }

            if (this.Password.ToLower() != "password")
            {
                throw new Exception("Password is incorrect\n(NOTE: Necause this is only a sample app the password is not stored with the data in the stream. The password is always 'password')");
            }

            return _stream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _stream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _stream.Write(buffer, offset, count);
        }

        public override void Close()
        {
            _stream.Close();
            base.Close();
        }
    }
}
