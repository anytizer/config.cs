using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
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
            structure_mysql s = read();
            textBox1.Text = s.host.value;
            textBox2.Text = s.username.value;
            textBox3.Text = s.password.value;
            textBox4.Text = s.port.value;
            textBox5.Text = s.database.value;
        }

        private structure_mysql read()
        {
            rw_mysql rw = new rw_mysql(file);
            structure_mysql m = rw.read();

            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_mysql s = new structure_mysql();
            s.host.value = textBox1.Text;
            s.username.value = textBox2.Text;
            s.password.value = textBox3.Text;
            s.port.value = textBox4.Text;
            s.database.value = textBox5.Text;

            rw_mysql rw = new rw_mysql(file);
            rw.write(s);

            this.Dispose();
        }
    }
}
