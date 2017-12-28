using configs.classes;
using configs.gui.editors;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace configs.gui
{
    public partial class Welcome : Form
    {
        private purposes names;

        public Welcome()
        {
            names = new purposes();
            InitializeComponent();
        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fTPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void set(Form f)
        {
            f.BackColor = Color.Aqua;
            f.FormBorderStyle = FormBorderStyle.Fixed3D;
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            f.StartPosition = FormStartPosition.CenterParent;

            f.ShowDialog(this);
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(".");
            textBox1.ReadOnly = true;
            textBox1.Text = fi.Directory.FullName;
        }

        private void aPIsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void softwareIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new SoftwareEditor(names.SOFTWARE_ID));
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serverOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new MySQLEditor(names.MYSQL_ONE));
        }

        private void serverTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new MySQLEditor(names.MYSQL_TWO));
        }

        private void hostOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new FTPEditor(names.FTP_ONE));
        }

        private void hostTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new FTPEditor(names.FTP_TWO));
        }

        private void userOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new UserEditor(names.USER_ONE));
        }

        private void userTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set(new UserEditor(names.USER_TWO));
        }

        private void aPIsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dropboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIEditor f = new APIEditor(names.API_ONE);
            f.Text = "Dropbox API Editor";

            set(f);
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIEditor f = new APIEditor(names.API_TWO);
            f.Text = "Twitter API Editor";

            set(f);
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIEditor f = new APIEditor(names.API_THREE);
            f.Text = "Facebook API Editor";

            set(f);
        }
    }
}
