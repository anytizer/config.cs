using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class SoftwareEditor : Form
    {
        string filename = "sotware.settings";
        public SoftwareEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void SoftwareEditor_Load(object sender, EventArgs e)
        {
            structure_software s = read();
            textBox1.Text = s.id.value;
            textBox2.Text = s.notes.value;
        }

        private structure_software read()
        {
            rw_software rw = new rw_software(filename);
            structure_software s = rw.read();

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_software s = new structure_software();
            s.id.value = textBox1.Text;
            s.notes.value = textBox2.Text;

            rw_software rw = new rw_software(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
