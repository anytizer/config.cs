using configs;
using configs.readerwriter;
using configs.structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui.editors
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
            ftp f = read();
            textBox1.Text = f.host.value;
            textBox2.Text = f.username.value;
            textBox3.Text = f.password.value;
            textBox4.Text = f.port.value;
        }

        private ftp read()
        {
            ftpconfig fc = new ftpconfig(file);
            ftp f = fc.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ftp f = new ftp();
            f.host.value = textBox1.Text;
            f.username.value = textBox2.Text;
            f.password.value = textBox3.Text;
            f.port.value = textBox4.Text;

            ftpconfig fc = new ftpconfig(file);
            fc.write(f);

            this.Dispose();
        }
    }
}
