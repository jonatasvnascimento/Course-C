﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContrutorOverloarding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste v = new teste("Cllarkron", 99);
            v.apresenta();
            v.apresenta("------>");
            v.apresenta("|||||>", 88);


        }
    }
}
