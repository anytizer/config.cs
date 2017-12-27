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
        string file = "api.settings";
        public APIEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void APIEditor_Load(object sender, EventArgs e)
        {
            structure_api s = read();
            textBox1.Text = s.key.value;
            textBox2.Text = s.secret.value;
        }

        private structure_api read()
        {
            rw_api rw = new rw_api(file);
            structure_api f = rw.read();

            return f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_api s = new structure_api();
            s.key.value = textBox1.Text;
            s.secret.value = textBox2.Text;

            rw_api rw = new rw_api(file);
            rw.write(s);

            this.Dispose();
        }
    }
}
