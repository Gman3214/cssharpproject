using System;
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
    public partial class gameone : Form
    {
        private frm_games mainform = null;
        public gameone(Form callingForm)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

    }
}
