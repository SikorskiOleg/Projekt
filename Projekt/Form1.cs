﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Wysluchaj_Click(object sender, EventArgs e)
        {
            wstep.Text = "Witaj w programie do nauki języka polskiego";
        }
    }
}
