﻿using configs.readerwriter;
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
            structure_user s = new structure_user();
            s.id.value = textBox1.Text;
            s.username.value = textBox2.Text;
            s.password.value = textBox3.Text;

            rw_user rw = new rw_user(file);
            rw.write(s);

            this.Dispose();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {
            structure_user s = read();
            textBox1.Text = s.id.value;
            textBox2.Text = s.username.value;
            textBox3.Text = s.password.value;
        }

        private structure_user read()
        {
            rw_user rw = new rw_user(file);
            structure_user s = rw.read();

            return s;
        }
    }
}