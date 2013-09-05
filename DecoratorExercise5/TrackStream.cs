using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise5
{
    public class TrackStream : Stream
    {
        private Stream _stream;
        private bool _isReading = false;

        public delegate void TrackStreamEventHandler(object sender, TrackStreamEventArgs e);

        public event TrackStreamEventHandler PositionChanged;

        public TrackStream(Stream stream)
        {
            this._stream = stream;
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

                //trigger event for tracking the number of bytes read
                if (_isReading)
                {
                    if (PositionChanged != null)
                        PositionChanged(this, new TrackStreamEventArgs("Position changed")
                            {
                                PercentRead = (int)((this.Position / this.Length) * 100)
                            });
                }
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            this._isReading = true;
            int nBytesRead = 0;
            for (nBytesRead = 0; nBytesRead < count && this.Position < this.Length; nBytesRead++)
            {
                int byteRead = _stream.ReadByte();
                if (byteRead == -1)
                    break;
                buffer[offset++] = (byte)byteRead;
                this.Position++;
            }

            //int nBytesRead = stream.Read(buffer, offset, count);
            this._isReading = false;
            return nBytesRead;
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
