using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class FTPEditor : Form
    {
        string file = "ftp.settings";
        public FTPEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void FTPEditor_Load(object sender, EventArgs e)
        {
            structure_ftp s = read();
            textBox1.Text = s.host.value;
            textBox2.Text = s.username.value;
            textBox3.Text = s.password.value;
            textBox4.Text = s.port.value;
            textBox5.Text = s.path.value;
        }

        private structure_ftp read()
        {
            rw_ftp rw = new rw_ftp(file);
            structure_ftp f = rw.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_ftp s = new structure_ftp();
            s.host.value = textBox1.Text;
            s.username.value = textBox2.Text;
            s.password.value = textBox3.Text;
            s.port.value = textBox4.Text;
            s.path.value = textBox5.Text;

            rw_ftp rw = new rw_ftp(file);
            rw.write(s);

            this.Dispose();
        }
    }
}
