using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class MySQLEditor : Form
    {
        string filename = "mysql.settings";

        public MySQLEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            structure_mysql s = read();
            textBox1.Text = s.host;
            textBox2.Text = s.username;
            textBox3.Text = s.password;
            textBox4.Text = s.port;
            textBox5.Text = s.database;
        }

        private structure_mysql read()
        {
            rw_mysql rw = new rw_mysql(filename);
            structure_mysql m = rw.read();

            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_mysql s = new structure_mysql();
            s.host = textBox1.Text;
            s.username = textBox2.Text;
            s.password = textBox3.Text;
            s.port = textBox4.Text;
            s.database = textBox5.Text;

            rw_mysql rw = new rw_mysql(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
