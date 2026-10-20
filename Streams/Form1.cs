namespace Streams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileStream_Click(object sender, EventArgs e)
        {
            FrmFileStream ffs = new FrmFileStream();
            ffs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStreamWriter fsw = new FrmStreamWriter();
            fsw.ShowDialog();
        }
    }
}
