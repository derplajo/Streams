using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Streams
{
    public partial class FrmStreamWriter : Form
    {
        private string docPath;
        public FrmStreamWriter()
        {
            InitializeComponent();
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //docPath = @"C:\Users\Admin\Desktop\test";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath);

                sw.WriteLine("This line was written using StreamWriter!");
                sw.WriteLine("Testing the Close() method.");

                MessageBox.Show("Text written successfully!\nClosing writer now...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    MessageBox.Show("StreamWriter is now closed!\nFile: " + txtInput.Text);
                }
            }
            ;
        }

        private void FrmStreamWriter_Load(object sender, EventArgs e)
        {

        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath);

                sw.WriteLine("Important log entry: System check passed.");

                sw.Flush();

                MessageBox.Show("Flush() executed!\nData is physically written to disk, but the stream is still OPEN for more writing.");

                sw.WriteLine("Another entry added after Flush().");

                MessageBox.Show("Second line written successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private void Write_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath);

                sw.Write("First Word ");
                sw.Write("Second Word ");
                sw.Write("Third Word");

                MessageBox.Show("Text written using Write() successfully!\nFile: " + txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private void btnWriteLine_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath);

                sw.WriteLine("First Word ");
                sw.WriteLine("Second Word ");
                sw.WriteLine("Third Word");

                MessageBox.Show("Text written using Write() successfully!\nFile: " + txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private void btnReadLine_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filePath);

                string firstLine = sr.ReadLine();

                string secondLine = sr.ReadLine();

                MessageBox.Show("Line 1: " + firstLine + "\nLine 2: " + secondLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading lines: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filePath);

                int charCode = sr.Read();

                if (charCode != -1)
                {
                    char character = (char)charCode;
                    MessageBox.Show("Character Code: " + charCode + "\nCharacter Read: " + character);
                }
                else
                {
                    MessageBox.Show("The file is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading character: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void btnReadToEnd_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filePath);

                string allContent = sr.ReadToEnd();

                MessageBox.Show("File Content (ReadToEnd):\n" + allContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filePath);

                int peekCode = sr.Peek();

                if (peekCode != -1)
                {
                    char peekChar = (char)peekCode;
                    MessageBox.Show("Peeked Character: " + peekChar + "\n(Pointer has NOT moved yet!)");
                }
                else
                {
                    MessageBox.Show("File is empty or at the end (Peek returned -1).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error peeking file: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(docPath, txtInput.Text + ".txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!\nFile: " + txtInput.Text);
                return;
            }

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                fs.Seek(5, SeekOrigin.Begin);

                sr = new StreamReader(fs);

                string contentFromOffset = sr.ReadToEnd();

                MessageBox.Show("Content starting from offset 5:\n" + contentFromOffset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
