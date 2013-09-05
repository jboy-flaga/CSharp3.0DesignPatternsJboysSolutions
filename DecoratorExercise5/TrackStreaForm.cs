using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorExercise5
{
    public partial class TrackStreaForm : Form
    {
        public TrackStreaForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text == string.Empty)
                MessageBox.Show("Textbox is empty");
            else
            {
                TrackStream trackStream = null;
                try
                {
                    FileStream fileStream = new FileStream(fileNameTextBox.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    //TrackStream is the decorator
                    trackStream = new TrackStream(fileStream);

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    //MessageBox.Show("trackStream.Length = " + trackStream.Length);
                    trackStream.PositionChanged += new TrackStream.TrackStreamEventHandler(trackStream_PositionChanged);
                    
                    ////write to stream : code is taken from http://geekswithblogs.net/TimH/archive/2005/06/27/44849.aspx
                    //System.Text.Encoding enc = System.Text.Encoding.ASCII;
                    //byte[] myByteArray = enc.GetBytes("qweruiopasdfjkl;zxcvnm,qweruioasdfjklxcvbmasdfjklqweuriopasdfjklzxcvm.asdjklqweuioasjklzxcvmasdjklfqweuoipasfdjklxcvuoibxcvnlmasdflqweiuqwehjasdjldxjoasdfuioaweoir");
                    //fileStream.Write(myByteArray, 0, myByteArray.Length);
                    
                    // the code below is based on the sample code on Streams at http://msdn.microsoft.com/en-us/library/system.io.stream.read%28v=vs.71%29.aspx
                    //read from stream
                    trackStream.Position = 0;

                    // Now read s into a byte buffer.
                    byte[] bytes = new byte[1000000];
                    int numBytesToRead = (int)trackStream.Length;
                    int n = trackStream.Read(bytes, 0, numBytesToRead);
                }
                catch (Exception ex)
                {
                    //if (trackStream != null)
                    //    MessageBox.Show("Position = " + trackStream.Position.ToString());
                    MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.GetType());
                }
                finally
                {
                    if (trackStream != null)
                    {
                        trackStream.Close();
                    }
                }
            }
        }

        void trackStream_PositionChanged(object sender, TrackStreamEventArgs e)
        {
            Stream stream = (Stream)sender;
            progressBar1.Value = e.PercentRead;
        }
    }
}
