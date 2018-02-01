using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class FTPEditor : Form
    {
        string filename = "ftp.settings";
        public FTPEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void FTPEditor_Load(object sender, EventArgs e)
        {
            structure_ftp s = read();
            textBox1.Text = s.host;
            textBox2.Text = s.username;
            textBox3.Text = s.password;
            textBox4.Text = s.port;
            textBox5.Text = s.path;
        }

        private structure_ftp read()
        {
            rw_ftp rw = new rw_ftp(filename);
            structure_ftp f = rw.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_ftp s = new structure_ftp();
            s.host = textBox1.Text;
            s.username = textBox2.Text;
            s.password = textBox3.Text;
            s.port = textBox4.Text;
            s.path = textBox5.Text;

            rw_ftp rw = new rw_ftp(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
