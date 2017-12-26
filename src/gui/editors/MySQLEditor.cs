using configs;
using configs.readerwriter;
using configs.structures;
using Newtonsoft.Json;
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

namespace gui.editors
{
    public partial class MySQLEditor : Form
    {
        string file = "mysql.settings";

        public MySQLEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            structure_mysql m = read();
            textBox1.Text = m.host.value;
            textBox2.Text = m.username.value;
            textBox3.Text = m.password.value;
            textBox4.Text = m.port.value;
            textBox5.Text = m.database.value;
        }

        private structure_mysql read()
        {
            rw_mysql mc = new rw_mysql(file);
            structure_mysql m = mc.read();

            return m;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            structure_mysql m = new structure_mysql();
            m.host.value = textBox1.Text;
            m.username.value = textBox2.Text;
            m.password.value = textBox3.Text;
            m.port.value = textBox4.Text;
            m.database.value = textBox5.Text;

            rw_mysql mc = new rw_mysql(file);
            mc.write(m);

            this.Dispose();
        }
    }
}
