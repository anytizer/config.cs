using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class HeadersEditor : Form
    {
        string filename = "headers.settings";
        public HeadersEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void HeadersEditor_Load(object sender, EventArgs e)
        {
            structure_headers s = read();
            textBox1.Text = s.authorization;
        }

        private structure_headers read()
        {
            rw_headers rw = new rw_headers(filename);
            structure_headers s = rw.read();

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_headers s = new structure_headers();
            s.authorization = textBox1.Text;

            rw_headers rw = new rw_headers(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
