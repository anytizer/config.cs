﻿using configs.classes.readerwriter;
using configs.classes.structures;
using System;
using System.Windows.Forms;

namespace configs.gui.editors
{
    public partial class UserEditor : Form
    {
        string filename;
        public UserEditor(string file)
        {
            this.filename = file;
            InitializeComponent();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {
            structure_user s = read();
            textBox2.Text = s.username;
            textBox3.Text = s.password;
        }

        private structure_user read()
        {
            rw_user rw = new rw_user(filename);
            structure_user s = rw.read();

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structure_user s = new structure_user();
            s.username = textBox2.Text;
            s.password = textBox3.Text;

            rw_user rw = new rw_user(filename);
            rw.write(s);

            this.Dispose();
        }
    }
}
