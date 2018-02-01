using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace writer.api
{
    public partial class Form1 : Form
    {
        private string filename = "api.settings";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            write();
            this.Dispose();
        }

        private void write()
        {
            structure_api s = new structure_api();
            s.key.value = textBox1.Text;
            s.secret.value = textBox2.Text;

            rw_api rw = new rw_api(filename);
            rw.write(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            read();
        }

        private void read()
        {
            if (System.IO.File.Exists(filename))
            {
                rw_api rw = new rw_api(filename);
                structure_api s = rw.read();

                textBox1.Text = s.key.value;
                textBox2.Text = s.secret.value;
            }
        }
    }
}
