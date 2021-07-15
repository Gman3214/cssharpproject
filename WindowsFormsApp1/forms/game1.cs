using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace exam
{
    public partial class gameone : Form
    {
        List<WordWImage> wordlist = new List<WordWImage>() ;
        private frm_games mainform = null;
        SoundPlayer wordsound = new SoundPlayer();
        static Random rnd = new Random();
        WordWImage currentword = null;
        public gameone(Form callingForm)
        {
            mainform = callingForm as frm_games;
            wordlist = mainform.gamewords;
            currentword = wordlist[rnd.Next(0, wordlist.Count - 1)];
            foreach(char letter in currentword.word)
            {
                
            }
            InitializeComponent();
        }

		private void Form3_Load(object sender, EventArgs e)
		{

		}

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_nextl.Text.Length != 1)
                MessageBox.Show("pls enter just one letter into the txtbox");
            else
            {

            }
        }
    }
}
