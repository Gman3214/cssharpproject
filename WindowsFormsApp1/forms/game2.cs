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
    public partial class gametwo : Form
    {
        private frm_games mainform = null;
        public List<WordWImage> gamewords = new List<WordWImage>();
        User player = new User();

        public gametwo(Form callingForm, List<WordWImage> gamewords,User player)
        {
            mainform = callingForm as frm_games;
            InitializeComponent();
            this.gamewords = gamewords;
            this.player = player;
            
        }

		private void gametwo_Load(object sender, EventArgs e)
		{

		}
	}
}
