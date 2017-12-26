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
    public partial class APIEditor : Form
    {
        string file="api.settings";
        public APIEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void APIEditor_Load(object sender, EventArgs e)
        {
            api m = read();
            textBox1.Text = m.key.value;
            textBox2.Text = m.secret.value;
        }

        private api read()
        {
            apiconfig fc = new apiconfig(file);
            api f = fc.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api f = new api();
            f.key.value = textBox1.Text;
            f.secret.value = textBox2.Text;

            apiconfig fc = new apiconfig(file);
            fc.write(f);

            this.Dispose();
        }
    }
}
