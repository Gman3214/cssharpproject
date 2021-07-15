﻿using System;
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
    public partial class frm_spelling : Form
    {
        List<WordWSpelling> spellingwords = new List<WordWSpelling>();
        User player = new User();
        SoundPlayer sp;
        static Random rnd = new Random();
        WordWSpelling[] randomwordsarr = new WordWSpelling[5];// אוסף מילים למשחק אחד
        List<int> getwrongans = new List<int>();// אוסף ששומר מילים שהשחקן טעה בהן
        int roundcounter = 0;
        bool useranswer = false;
        public frm_spelling(List<WordWSpelling> spellingwords,User player)
        {
            sp = new SoundPlayer();
            this.spellingwords = spellingwords;// לקיחת אוסף המילים מטופס הבית 
            this.player = player;// לקיחת הדתא של השחקן שלנו מטופס הבית
            InitializeComponent();
        }

		private void frm_spelling_Load(object sender, EventArgs e)// ברגע כניסה לאיות 
		{
            cbx_ans1.Visible = false; cbx_ans2.Visible = false; cbx_ans3.Visible = false; cbx_ans4.Visible = false;// כל הפקדים בלתי נראים עד לחיצה על השמע
			loadwrongs();btn_chkres.Enabled = false;
            pic_great.Visible = false;lbl_feedback.Visible = false;pic_failed.Visible = false;
            Letgetstarted();
		}
        private void startnewround()//  בחירת מילה רנדומלית ובדיקה שעדיין לא הוצגה למשתמש והחזרתה למשחק.
		{
            //if(roundcounter !=4) לזכור שיש בסך הכל חמישה סיבובים
            randomwordsarr[roundcounter] = randomspelslc();
            for (int i = 0;i<roundcounter;i++)// בודק שהמילה הרדנומלית שנבחרה עדיין לא הופיעה בסיבובים קודמים  
			{
                if(randomwordsarr[roundcounter].CompareTo(randomwordsarr[i])==0)
				{
                    randomwordsarr[roundcounter] = randomspelslc();
                    i = 0;
				}
			}
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
        private void Letgetstarted()
		{
            startnewround();
            playermedia.Enabled = true;
            string[] answ = { randomwordsarr[roundcounter].word, randomwordsarr[roundcounter].wrong1, randomwordsarr[roundcounter].wrong2, randomwordsarr[roundcounter].wrong3 };
            // מערך תשובות עבור הפקדים
            //string right = randomwordsarr[roundcounter].word;// שומר על התשובה הנכונה
            cbx_ans1.Visible = true; cbx_ans2.Visible = true; cbx_ans3.Visible = true; cbx_ans4.Visible = true;
            int r = rnd.Next(0,3);
            cbx_ans1.Text = answ[r];
            cbx_ans2.Text = answ[(r + 1) % 4];
            cbx_ans3.Text = answ[(r + 2) % 4];
            cbx_ans4.Text = answ[(r + 3) % 4];
            if (cbx_ans1.Checked == true || cbx_ans2.Checked == true || cbx_ans3.Checked == true || cbx_ans4.Checked == true)
                btn_chkres.Enabled = true;
        }


		private void loadwrongs()// מתודה שקוראת את כל המספרים הסידוריים של המילים בקובץ המילים שהמשתמש טעה בהן, ואוספת אותן לרשימה
		{
			try
			{
				StreamReader sr = new StreamReader(@"DATA\" + player.username + "_WrongSPELLING.txt");
				string str = null;
				while ((str = sr.ReadLine()) != null)
					getwrongans.Add(int.Parse(str));
				sr.Close();
			}
			catch (IOException copyError)
			{
				MessageBox.Show("error loading from data");
			}
		}


		private WordWSpelling randomspelslc()// פונקציה שבוחרת מילה רנדומלית מתוך אוסף המילים לאיות שלנו
		{
            if(getwrongans.Count!=0)//אם אוסף המילים שהמשתמש טעה בהן אינו ריק
			{
                int r = rnd.Next(0,getwrongans.Count-1);//משתנה אינדקס רנדומלי מאוסף המילים
                for(int i =0;i<spellingwords.Count;i++)
				{
                    if (getwrongans[r] == spellingwords[i].wordid)//עוברים על אוסף המילים הכללי ומוצאים את האובייקט בעל אותו id
                        return spellingwords[i];//מחזירים מילה שקיימת באוסף המילים שהמשתמש טעה כאובייקט
				}
			}
                int y = rnd.Next(spellingwords.Count);//אחרת, ניקח מילה רנדומלית מתוך אוסף המילים שלנו. 
                return spellingwords[y]; 
        }

		

		private void btn_chkres_Click(object sender, EventArgs e)// בודקת את הבחירה של המשתמש
		{
            playermedia.Enabled = false;
           if(useranswer==true)
			{
                pic_great.Visible = true;
                lbl_feedback.Text = "You doing great! \n keep going!";
			}
			else// מקרה שהמשתמש בחר בתשובה לא נכונה
			{
				lbl_feedback.Text = "oh well, We learn something new every day";
                pic_failed.Visible = true;
                
                // הכנסה לתוך קובץ הwrong של המשתמש
                using (StreamWriter newword = new StreamWriter(@"DATA\" + player.username + "_WrongSPELLING.txt", true))
                { newword.WriteLine(randomwordsarr[roundcounter].wordid+"\r\n"); }
            }
            roundcounter++;
            btn_chkres.Enabled = false;
           
		}

		private void playermedia_Click(object sender, EventArgs e)
		{
            sp.SoundLocation = randomwordsarr[roundcounter].wordwav;
            sp.Play();
        }

		private void cbx_ans2_CheckedChanged(object sender, EventArgs e)
		{
            if(cbx_ans2.Checked==true)
			{
                cbx_ans3.Enabled = false;
                cbx_ans4.Enabled = false;
                cbx_ans1.Enabled = false;
            }
            if (cbx_ans2.Checked == true && randomwordsarr[roundcounter].word == cbx_ans2.Text)// בדיקה שמה שנבחר אכן התשובה הנכונה
                useranswer = true;
		}

		private void cbx_ans1_CheckedChanged(object sender, EventArgs e)
		{
            if (cbx_ans1.Checked == true)
            {
                cbx_ans3.Enabled = false;
                cbx_ans4.Enabled = false;
                cbx_ans2.Enabled = false;
            }
            if (cbx_ans1.Checked == true && randomwordsarr[roundcounter].word == cbx_ans1.Text)
                useranswer = true;
        }

		private void cbx_ans4_CheckedChanged(object sender, EventArgs e)
		{
            if (cbx_ans4.Checked == true)
            {
                cbx_ans3.Enabled = false;
                cbx_ans2.Enabled = false;
                cbx_ans1.Enabled = false;
            }
            if (cbx_ans4.Checked == true && randomwordsarr[roundcounter].word == cbx_ans4.Text)
                useranswer = true;
        }

		private void cbx_ans3_CheckedChanged(object sender, EventArgs e)
		{
            if (cbx_ans3.Checked == true)
            {
                cbx_ans2.Enabled = false;
                cbx_ans4.Enabled = false;
                cbx_ans1.Enabled = false;
            }
            if (cbx_ans3.Checked == true && randomwordsarr[roundcounter].word == cbx_ans3.Text)
                useranswer = true;
        }
	}
}
