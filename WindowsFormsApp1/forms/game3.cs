﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class gametri : Form
    {
        private frm_games mainform = null;
        public gametri(Form callingForm)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
        }
    }
}
