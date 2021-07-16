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
    public partial class MainScreen : Form
    {
         List<WordWSpelling> spellingwords = new List<WordWSpelling>();
         List<WordWImage> gamewords = new List<WordWImage>();
         Dictionary<string, User> users = new Dictionary<string, User>();
        User player = new User();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_submitmail_Click(object sender, EventArgs e)// הכנסת המייל שהמשתמש רשם
        {
            bool check = false;
            check = checkemail(txt_email.Text);
            if (check == false)
            {
                MessageBox.Show("your email is invalid\npls enter a valid email address");
            }
            else
            {
                User person = checkmailindatabase(txt_email.Text);// קריאה למתודה שבודקת אם המייל כבר קיים במערכת או לא. המתודה מחזירה לנו את המשתמש.
                                                                  //במידה והמשתמש היה קיים במערכת, היא מאתרת איזה משתמש זה ומחזירה לנו את ה user שלו
                                                                  // במידה והמשתמש לא היה קיים מעולם במערכת, המתודה כבר הוסיפה אותו למערכת ומחזירה לנו את המשתמש שהיא יצרה עבור המייל שלו 
                                                                  // הערה : לא נדרש מאיתנו להודיע למשתמש אם היה קיים כבר במערכת או שהוא חדש. ולכן לא צריך ליצור הודעה על כך עבור המשתמש
                
                player = person;
                lbl_hello.Text = "Hello "+person.username+"\nNice to see you";
                lbl_hello.Show();
                btn_games.Enabled=true;
                btn_spelling.Enabled = true;
                btn_add.Enabled = true;
                if(gamewords.Count==0)
                    creategameslist();
                if (spellingwords.Count == 0)
                    createspellinglist();
                lblname_.Visible = true; lblname_.Text = player.username; lblscore_.Visible = true;
                lblscore_.Text = "score:" + player.genralscore;
                txt_email.Visible = false; lbl_mail.Visible = false;
                pic_user.Visible = true;btn_submitmail.Visible = false;
            }

        }
        bool checkemail(string mail) // בודק שהמייל שהוכנס תקין 
        {
            int checksh = 0;
            foreach (char value in mail)
            {
                if (value == ' ')
                    return false;
                if (value == '@')
                    checksh = 1;
                if (value == '.' && checksh == 1)
                    return true;
            }
            return false;
        }
   
        User checkmailindatabase(string mail)// בודק האם המייל שהוכנס קיים בזיכרון אם כן מחזיר את האובייקט שמשויך למייל ואם לא יוצר משתמש חדש בזיכרון
        {
            User person;
            foreach (KeyValuePair<string, User> pair in users)
            {
				if (pair.Key == mail)
                {
                    person = pair.Value;
                    return person;
                }
					
            }
            person = new User(mail);
            users.Add(mail,person);  // להוסיף את הפרסון למערך המשתמשים
            return person;
        }
        private void btn_games_Click(object sender, EventArgs e)
        {
            openform(new frm_games (gamewords, player,lblscore_));// שולח לפונקציית פתח פורמ את הפורמ של המשחקים
        }
        private Form activeform = null;
        private void openform (Form child)// פותחת את הפורמ שנשלח לה בקריאה לפונקציה
        {
            if (activeform != null)
                activeform.Close();
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnl_childfrm.Controls.Add(child);
            pnl_childfrm.Tag = child;
            child.BringToFront();
            child.Show();  
        }

        private void btn_spelling_Click(object sender, EventArgs e)
        {
            openform(new frm_spelling (spellingwords,player, lblscore_));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            openform(new frm_add(spellingwords, gamewords));
        }
         WordWSpelling createWspelling(string line) //יוצר מתוך שורה בקובץ טקסט אובייקט מסוג wordspelling
        {
            string[] linebreak = line.Split(';');
            WordWSpelling wordcreated = new WordWSpelling(linebreak[3], linebreak[4], linebreak[5], linebreak[1], int.Parse(linebreak[0]), linebreak[2]);
            return wordcreated;
        }
        void createspellinglist()// המרת טופס מילים לאיות לתוך אובייקטים ואז לתוך הרשימה של המילים לאיות
        {
            StreamReader spelling = new StreamReader(@"DATA\SpellWords.txt");
            string str = null;
            while ((str = spelling.ReadLine()) != null)
            {
                WordWSpelling word = createWspelling(str);
                spellingwords.Add(word);
            }
            spelling.Close();
        }
        WordWImage createWimage(string line)// יוצר מתוך שורה בקובץ טקסט אובייקט מסוג wordwimage
        {
            string[] linebreak = line.Split(';');
            char[] letters = new char[linebreak.Length-4];
            for (int i = 4; i < linebreak.Length; i++)// יוצר מארך של אותיות המילה
            {
                foreach (char value in linebreak[i])
                    letters[i - 4] = value;
            }
            WordWImage wordcreated = new WordWImage(linebreak[2], linebreak[1].Length, letters, linebreak[1], int.Parse(linebreak[0]), linebreak[3]);
            return wordcreated;
        }
        void creategameslist()// המרת הטופס לאובייקטים והכנסתם לרשימת המילים למשחקים 
        {
            StreamReader game = new StreamReader(@"DATA\wordImageData.txt");
            while (!game.EndOfStream)
            {
                WordWImage word = createWimage(game.ReadLine());
                gamewords.Add(word);
            }
            game.Close();
        }
	}
}
