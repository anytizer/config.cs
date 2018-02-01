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

namespace writer.mysql
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

                textBox1.Text = s.host;
                textBox2.Text = s.username;
                textBox3.Text = s.password;
                textBox4.Text = s.port;
                textBox5.Text = s.database;
            }
        }

        private void write()
        {
            structure_mysql s = new structure_mysql();
            s.host = textBox1.Text;
            s.username = textBox2.Text;
            s.password = textBox3.Text;
            s.port = textBox4.Text;
            s.database = textBox5.Text;

            rw_mysql rw = new rw_mysql("mysql.settings");
            rw.write(s);
        }
    }
}
