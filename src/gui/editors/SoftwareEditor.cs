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

namespace configs.gui.editors
{
    public partial class SoftwareEditor : Form
    {
        string file = "sotware.settings";
        public SoftwareEditor(string file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_software s = new structure_software();
            s.id.value = textBox1.Text;
            s.notes.value = textBox2.Text;

            rw_software rw = new rw_software(file);
            rw.write(s);

            this.Dispose();
        }

        private void SoftwareEditor_Load(object sender, EventArgs e)
        {
            structure_software s = read();
            textBox1.Text = s.id.value;
            textBox2.Text = s.notes.value;
        }

        private structure_software read()
        {
            rw_software rw = new rw_software(file);
            structure_software s = rw.read();

            return s;
        }
    }
}
