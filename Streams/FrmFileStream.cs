using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Streams
{
    public partial class FrmFileStream : Form
    {
        private string docPath;
        public FrmFileStream()
        {
            InitializeComponent();
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //docPath = @"C:\Users\Admin\Desktop\test";
        }

        private void FrmFileStream_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                MessageBox.Show("File Created Successfully!\nFile: " + txtInput.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");
            using (FileStream fs = new FileStream(filePath, FileMode.CreateNew))
            {
                MessageBox.Show("New File Created Successfully!\nFile: " + txtInput.Text.Trim() + ".txt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                MessageBox.Show($"File Opened Successfully!\nFile: {txtInput.Text.Trim()}.txt\nSize: {fs.Length} bytes");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                MessageBox.Show($"File Opened or Created Successfully!\nFile: {txtInput.Text.Trim()}.txt\nSize: {fs.Length} bytes");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.Truncate))
            {
                MessageBox.Show($"File Truncated Successfully!\nFile: {txtInput.Text.Trim()}.txt\nSize: {fs.Length} bytes");
            }
        }

        private void btnReadByte_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int b = fs.ReadByte();

                if (b != -1)
                {
                    MessageBox.Show($"Byte: {b}\nCharacter: {(char)b}");
                }
                else
                {
                    MessageBox.Show("File is empty (End of File).");
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];

                int bytesRead = fs.Read(buffer, 0, buffer.Length);

                string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                MessageBox.Show($"Bytes read: {bytesRead}\n\nContent:\n{content}");
            }
        }

        private void btnWriteByte_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Seek(0, SeekOrigin.End);

                byte b = (byte)'A';
                fs.WriteByte(b);

                MessageBox.Show($"Byte Written Successfully!\nCharacter: {(char)b}\nNew File Size: {fs.Length} bytes");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string textToWrite = "Hello from fs.Write!";
                byte[] buffer = Encoding.UTF8.GetBytes(textToWrite);

                fs.Seek(0, SeekOrigin.End);

                fs.Write(buffer, 0, buffer.Length);

                MessageBox.Show($"Data Written Successfully!\nBytes written: {buffer.Length}\nTotal File Size: {fs.Length} bytes");
            }
        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes("Data buffered in memory...");
                fs.Write(buffer, 0, buffer.Length);

                fs.Flush();

                MessageBox.Show($"Buffer flushed successfully!\nFile Size: {fs.Length} bytes");
            }
        }

        private void btnCanRead_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (fs.CanRead)
                {
                    byte[] buffer = new byte[fs.Length];
                    int bytesRead = fs.Read(buffer, 0, buffer.Length);

                    string fileContent = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    MessageBox.Show("CanRead: " + fs.CanRead + "\nFile Content:\n" + fileContent);
                }
                else
                {
                    MessageBox.Show("The stream cannot be read.");
                }
            }
        }

        private void btnCanSeek_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (fs.CanSeek)
                {
                    fs.Seek(123, SeekOrigin.Begin);

                    MessageBox.Show("CanSeek: " + fs.CanSeek +
                                    "\nFile pointer successfully moved to Position: " + fs.Position);
                }
                else
                {
                    MessageBox.Show("The stream does not support seeking.");
                }
            }
        }

        private void btnCanTimeout_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (fs.CanTimeout)
                {
                    fs.ReadTimeout = 3000;
                    fs.WriteTimeout = 3000;

                    MessageBox.Show("CanTimeout: " + fs.CanTimeout +
                                    "\nReadTimeout set to: " + fs.ReadTimeout + " ms");
                }
                else
                {
                    MessageBox.Show("CanTimeout: " + fs.CanTimeout +
                                    "\nThis stream does not support timeouts.");
                }
            }
        }

        private void btnCanWrite_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write))
            {
                if (fs.CanWrite)
                {
                    MessageBox.Show("CanWrite: " + fs.CanWrite +
                                    "\nThis file is open with write permissions.");
                }
                else
                {
                    MessageBox.Show("CanWrite: " + fs.CanWrite +
                                    "\nThis stream cannot be written to.");
                }
            }
        }
    }
}
