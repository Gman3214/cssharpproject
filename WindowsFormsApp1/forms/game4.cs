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
    public partial class gamefour : Form
    {
        private frm_games mainform = null;
        public gamefour(Form callingForm, WordWImage[] gamewords, User player)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
        }
    }
}
