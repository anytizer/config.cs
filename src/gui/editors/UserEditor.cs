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
    public partial class UserEditor : Form
    {
        string file;
        public UserEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_user m = new structure_user();
            m.id.value = textBox1.Text;
            m.username.value = textBox2.Text;
            m.password.value = textBox3.Text;

            rw_user mc = new rw_user(file);
            mc.write(m);

            this.Dispose();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {
            structure_user m = read();
            textBox1.Text = m.id.value;
            textBox2.Text = m.username.value;
            textBox3.Text = m.password.value;
        }

        private structure_user read()
        {
            rw_user mc = new rw_user(file);
            structure_user m = mc.read();

            return m;
        }
    }
}
