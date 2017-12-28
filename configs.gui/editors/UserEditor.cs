using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class UserEditor : Form
    {
        string file;
        public UserEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {
            structure_user s = read();
            textBox2.Text = s.username.value;
            textBox3.Text = s.password.value;
        }

        private structure_user read()
        {
            rw_user rw = new rw_user(file);
            structure_user s = rw.read();

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_user s = new structure_user();
            s.username.value = textBox2.Text;
            s.password.value = textBox3.Text;

            rw_user rw = new rw_user(file);
            rw.write(s);

            this.Dispose();
        }
    }
}
