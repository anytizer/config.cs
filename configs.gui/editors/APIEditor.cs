using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class APIEditor : Form
    {
        string filename = "api.settings";
        public APIEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void APIEditor_Load(object sender, EventArgs e)
        {
            structure_api s = read();
            textBox1.Text = s.key;
            textBox2.Text = s.secret;
        }

        private structure_api read()
        {
            rw_api rw = new rw_api(filename);
            structure_api s = rw.read();

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_api s = new structure_api();
            s.key = textBox1.Text;
            s.secret = textBox2.Text;

            rw_api rw = new rw_api(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
