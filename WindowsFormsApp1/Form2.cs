﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string textBox2_TextChanged
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string textBox1_TextChanged
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public int numericUpDown1_ValueChanged
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }
    }
}
