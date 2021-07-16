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
using System.IO;

namespace exam
{

    public partial class gamefour : Form
    {
        List<WordWImage> allgamewords = new List<WordWImage>();
        private frm_games mainform = null;
        SoundPlayer wordsound = new SoundPlayer();
        User player = new User();
        WordWImage[] randomwordsgame = new WordWImage[3];
        int roundnum = 0;
        int points = 0;
        WordWImage[] randomtopics = new WordWImage[2];
        WordWImage fake = null;
        static Random rnd = new Random();
        int ticks = 0;
        int timeleft = 0;
        public gamefour(Form callingForm, WordWImage[] gamewords, User player, List<WordWImage> allgamewords)
        {
            this.allgamewords = allgamewords;
            mainform = callingForm as frm_games;
            this.randomwordsgame = gamewords;
            this.player = player;
            InitializeComponent();
            start();
        }//קישור האובייקטים שנשלחו 
        public void start()
        {
            if (roundnum < 3)
            {
                if (player.wrongamewords.Count < 2)
                    timeleft = 5;
                else
                    timeleft = 10;
                wordsound.SoundLocation = @"VOICE/" + randomwordsgame[roundnum].wordwav;
                wordsound.Play();
                fake = allgamewords[getren()];
                int y = rnd.Next(0, 2);
                randomtopics[y] = randomwordsgame[roundnum];
                randomtopics[(y + 1) % 2] = fake;
                pic_left.ImageLocation = @"DIMAGES\" + randomtopics[0].wordimg;
                pic_right.ImageLocation = @"DIMAGES\" + randomtopics[1].wordimg;
                lbl_points.Text = "score:" + points;
                lbl_time.Text = "time left:" + (timeleft - ticks - 1);
                timer1.Enabled = true;
            }
            else
            {
                btn_sound.Enabled = false;
                pic_left.Enabled = false;
                pic_right.Enabled = false;
                lbl_points.Text = "score:" + points; 
                btn_exit.Visible = true;
            }
                
        }//איתחול מצב המשחק בכל סבב של המשחק ובדיקה שלא סיימנו את הסבב האחרון במקרה שסיימנו עוצר ונותן אפשרות יציאה
        private int getren()
        {
            int y = rnd.Next(allgamewords.Count);
            while (y == randomwordsgame[roundnum].wordid)
                y=getren();
            return y;
        }//מביא מילה רנדומלית שונה מהמילה המקורית 
        private void btn_sound_Click(object sender, EventArgs e)
        {
            wordsound.Play();
        }//מפעיל את השמע שוב
        private void pic_left_Click(object sender, EventArgs e)
        {
            if (fake == randomtopics[1])
                win();
            else
                lose();

        }//בודק אם הבחירה של השחקן נכונה ושולח לניצחון או הפסד בהתאמה
        private void pic_right_Click(object sender, EventArgs e)
        {
            if (fake == randomtopics[0])
                win();
            else
                lose();
        }//בודק אם הבחירה של השחקן נכונה ושולח לניצחון או הפסד בהתאמה
        private void win()
        {
            player.chkmypast(randomwordsgame[roundnum]);
            roundnum++;
            lbl_enco.Visible = true;
            lbl_enco.Text = "you pressed the correct pic good job :3";
            points = points + 5;
            resettime();
            start();
        }//אומר לשחקן שהוא הצליח מוסיף לו ניקוד מאתחל שעון ושולח להתחלה
        private void lose()
        {
            player.updatemypast(randomwordsgame[roundnum]);
            roundnum++;
            lbl_enco.Visible = true;
            lbl_enco.Text = "you pressed the wrong pic, better luck next time :)";
            points = points - 5;
            resettime();
            start();
        }//אומר לשחקן שהוא נכשל מוסיף לו ניקוד מאתחל שעון ושולח להתחלה
        private void btn_exit_Click(object sender, EventArgs e)
        {
            player.scoreupdate(points);
            this.Close();
        }//מעדכן את הנקודות של השחקן מחוץ למשחק ומוציא אותו מהמשחק 
        private void resettime()
        {
            ticks = 0;
            timer1.Enabled = false;
        }//מאתחל אלמנטים של שעון
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            lbl_time.Text = "time left:" + (timeleft - ticks - 1);
            if (timeleft - ticks == 0)
                lose();
        }//בודק שלא נגמר הזמן שיש לשחקן (אם הוא נפסל יותר מפעמיים אז 10 אם נפסל פחות אז 5 שניות)ושולח אותו להפסד אם הזמן נגמר
    }
}
