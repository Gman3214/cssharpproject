using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace exam
{
    public partial class frm_games : Form
    {
        Label scorelbl = new Label();
        public List<WordWImage> gamewords = new List<WordWImage>();//כל המילים ברשימה
        User player = new User();
        int points = 0;
        static Random rnd = new Random();
        WordWImage[] randomwordsgame = new WordWImage[3];//רשימה עבור כל משחק של שלוש מילים רנדומליות
        int index = 0;

        public frm_games(List<WordWImage> gamewords, User player, Label lblscore)
        {
            this.player = player;
            this.gamewords = gamewords;
            InitializeComponent();
            this.scorelbl = lblscore;
        }

        public int score
        {
            get { return points; }
            set { points = points + value; }
        }
        private void pix_game1_Click_1(object sender, EventArgs e)
        {
            buildrandomarr();
            gameone game1 = new gameone(this,player, randomwordsgame);
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
            buildrandomarr();
            gametri game3 = new gametri(this, randomwordsgame, player);
            game3.Show();
        }

        private void pix_game4_Click(object sender, EventArgs e)
        {
            buildrandomarr();
            gamefour game4 = new gamefour(this, randomwordsgame, player, gamewords);
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
                int r = rnd.Next(0, player.wrongamewords.Count);
                //משתנה אינדקס רנדומלי מאוסף המילים שהמשתמש טעה בהן בעבר!!!
                for ( int i = 0; i < gamewords.Count; i++)
                    if (player.wrongamewords[r] == gamewords[i].wordid)
                    {
                        j = i;
                        return gamewords[j];
                    }//עוברים על אוסף המילים הכללי ומוצאים את האובייקט בעל אותו id
                       //מחזירים מילה שקיימת באוסף המילים שהמשתמש טעה כאובייקט
            return randomfromall();
        }
        private void buildrandomarr()// בניית מערך של 3 מילים רנדומליות עבור משחק בודד
		{
            for (int i = 0; i < 3; i++)
            {
                if (i < player.wrongamewords.Count)
                {
                    randomwordsgame[i] = randomfromworngs();
                    for (int j = 0; j < i; j++)
                    {
                        while (randomwordsgame[i]==randomwordsgame[j]) 
                        {
                            randomwordsgame[i] = randomfromworngs();
                            j = 0;
                        }
                    }
                }
                else
                    randomwordsgame[i] = randomfromall();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("do you want to save your data for next time?", "save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            { 
               try
                {
                    using (StreamWriter newword = new StreamWriter(@"OUTPUT\" + player.username + "_wrong.txt"))
                    {
                         for (int i = 0; i < player.wrongamewords.Count; i++)
                            newword.WriteLine( player.wrongamewords[i]);
                    }
                }
                catch (IOException copyError)
                {
                    MessageBox.Show(copyError.Message);
                }
            }
            scorelbl.Text = "score:" + player.genralscore;
            this.Close();
        }
    }
	
}
