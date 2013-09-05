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

namespace DecoratorExercise6
{
    public partial class PasswordProtectedStreamForm : Form
    {
        public PasswordProtectedStreamForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {



            if (fileNameTextBox.Text == string.Empty)
                MessageBox.Show("Textbox is empty");
            else
            {
                PasswordProtectedStream passStream = null;
                try
                {
                    FileStream fileStream = new FileStream(fileNameTextBox.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    passStream = new PasswordProtectedStream(fileStream, passwordTextBox.Text);

                    byte[] bytes = new byte[1000000];
                    int numBytesToRead = (int)passStream.Length;
                    int n = passStream.Read(bytes, 0, numBytesToRead);

                    MessageBox.Show("Read successful");
                }
                catch (Exception ex)
                {
                    //if (trackStream != null)
                    //    MessageBox.Show("Position = " + trackStream.Position.ToString());
                    MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.GetType());
                }
                finally
                {
                    if (passStream != null)
                    {
                        passStream.Close();
                    }
                }
            }
        }
    }
}
