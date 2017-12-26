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
            structure_ftp f = read();
            textBox1.Text = f.host.value;
            textBox2.Text = f.username.value;
            textBox3.Text = f.password.value;
            textBox4.Text = f.port.value;
        }

        private structure_ftp read()
        {
            rw_ftp fc = new rw_ftp(file);
            structure_ftp f = fc.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_ftp f = new structure_ftp();
            f.host.value = textBox1.Text;
            f.username.value = textBox2.Text;
            f.password.value = textBox3.Text;
            f.port.value = textBox4.Text;

            rw_ftp fc = new rw_ftp(file);
            fc.write(f);

            this.Dispose();
        }
    }
}
