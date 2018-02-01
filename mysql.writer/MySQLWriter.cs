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

namespace mysql.writer
{
    public partial class MySQLWriter : Form
    {
        private string filename = "mysql.settings";
        public MySQLWriter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write();
            this.Dispose();
        }

        private void read()
        {
            if(System.IO.File.Exists(filename))
            {
                rw_mysql rw = new rw_mysql("mysql.settings");
                structure_mysql s = rw.read();

                textBox1.Text = s.host.value;
                textBox2.Text = s.username.value;
                textBox3.Text = s.password.value;
                textBox4.Text = s.port.value;
                textBox5.Text = s.database.value;
            }
        }

        private void write()
        {
            structure_mysql s = new structure_mysql();
            s.host.value = textBox1.Text;
            s.username.value = textBox2.Text;
            s.password.value = textBox3.Text;
            s.port.value = textBox4.Text;
            s.database.value = textBox5.Text;

            rw_mysql rw = new rw_mysql("mysql.settings");
            rw.write(s);
        }
    }
}
