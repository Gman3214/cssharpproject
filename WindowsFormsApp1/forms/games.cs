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
    public partial class frm_games : Form
    {
        public List<WordWImage> gamewords = new List<WordWImage>();
        User player = new User();
        int points = 0;
        static Random rnd = new Random();
        WordWImage[] randomwordsgame = new WordWImage[3];
        int index = 0;

        public frm_games(List<WordWImage> gamewords, User player)
        {
            this.player = player;
            this.gamewords = gamewords;
            InitializeComponent();
        }

        public int score
        {
            get { return points; }
            set { points = points + value; }
        }
        private void pix_game1_Click_1(object sender, EventArgs e)
        {
            gameone game1 = new gameone(this, gamewords);
            game1.Show();
        }

        private void pix_game2_Click(object sender, EventArgs e)
        {
            buildrandomarr();
            gametwo game2 = new gametwo(this, randomwordsgame, player);
            game2.Show();
        }

        private void pix_game3_Click(object sender, EventArgs e)
        {
            gametri game3 = new gametri(this);
            game3.Show();
        }

        private void pix_game4_Click(object sender, EventArgs e)
        {
            gamefour game4 = new gamefour(this);
            game4.Show();
        }

        private WordWImage randomfromall()
        {
            int y = rnd.Next(gamewords.Count);//אחרת, ניקח מילה רנדומלית מתוך אוסף המילים שלנו. 
            return gamewords[y];
        }
        private void pix_back_Click(object sender, EventArgs e)
        {

        }
        private WordWImage randomfromworngs()// פונקציה שבוחרת מילה רנדומלית מתוך אוסף המילים לאיות שלנו
        {
            int j = 0;
            if (player.wrongamewords.Count != 0)
            //אם אוסף המילים שהמשתמש טעה בהן אינו ריe
            {
                int r = rnd.Next(0, player.wrongamewords.Count - 1);
                //משתנה אינדקס רנדומלי מאוסף המילים שהמשתמש טעה בהן בעבר!!!
                for (int i = 0; i < gamewords.Count; i++)
                    if (player.wrongamewords[r] == gamewords[i].wordid)//עוברים על אוסף המילים הכללי ומוצאים את האובייקט בעל אותו id
                        return gamewords[j];//מחזירים מילה שקיימת באוסף המילים שהמשתמש טעה כאובייקט
            }
            return randomfromall();
        }
        private void buildrandomarr()// בניית מערך של 3 מילים רנדומליות עבור משחק בודד
		{
            for (int i = 0; i < 3; i++)
			{
                randomwordsgame[i] = randomfromworngs();
                for (int j = 0; j < i; j++)
				{
                    if (randomwordsgame[i].CompareTo(randomwordsgame[j]) == 0)
					{
                        randomwordsgame[i] = randomfromworngs();
                        j = 0;
                    }
				}

            }

        }
	
    }
}
