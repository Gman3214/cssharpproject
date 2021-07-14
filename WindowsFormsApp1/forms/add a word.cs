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
    public partial class frm_add : Form 
    {
        List<WordWSpelling> spellingwords = new List<WordWSpelling>();
        List<WordWImage> gamewords = new List<WordWImage>();
        public frm_add(List<WordWSpelling> spellingwords, List<WordWImage> gamewords)
        {
            this.spellingwords = spellingwords;
            this.gamewords = gamewords;
            InitializeComponent();
        }

        private void cbx_spelling_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_spelling.Checked==true )
            {
                cbx_games.Enabled = false;
                lbl_word.Visible = true;txt_addword.Visible = true;
                lbl_addsound.Visible = true;txt_addsound.Visible = true;btn_selectsound.Visible = true;
                lbl_addwrong1.Visible = true;txt_wrong1.Visible = true;
                lbl_addwrong2.Visible = true; txt_wrong2.Visible = true;
                lbl_addwrong3.Visible = true; txt_wrong3.Visible = true;
            }
            if (cbx_spelling.Checked == false)
            {
                cbx_games.Enabled = true;
                lbl_word.Visible = false; txt_addword.Visible = false;
                lbl_addsound.Visible = false; txt_addsound.Visible = false; btn_selectsound.Visible = false;
                lbl_addwrong1.Visible = false; txt_wrong1.Visible = false;
                lbl_addwrong2.Visible = false; txt_wrong2.Visible = false;
                lbl_addwrong3.Visible = false; txt_wrong3.Visible = false;
            }
        }

        private void cbx_games_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_games.Checked == true)
            {
                cbx_spelling.Enabled = false;
                lbl_word.Visible = true; txt_addword.Visible = true;
                lbl_addsound.Visible = true; txt_addsound.Visible = true; btn_selectsound.Visible = true;
                lbl_addpic.Visible = true; txt_addpic.Visible = true; btn_slctpic.Visible = true;
            }
            if (cbx_games.Checked == false)
            {
                cbx_spelling.Enabled = true;
                lbl_word.Visible = false; txt_addword.Visible = false;
                lbl_addsound.Visible = false; txt_addsound.Visible = false; btn_selectsound.Visible = false;
                lbl_addpic.Visible = false; txt_addpic.Visible = false; btn_slctpic.Visible = false;
            }
        }
        private void btn_selectsound_Click(object sender, EventArgs e)
        {
           OpenFileDialog soundfile = new OpenFileDialog();
           soundfile.Filter = "file wav | *.wav";
           if(soundfile.ShowDialog()==DialogResult.OK)
            {
                txt_addsound.Text = soundfile.FileName;
            }
        }

        private void btn_slctpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog picfile = new OpenFileDialog();
            picfile.Filter = "file jpg | *.jpg";
            if (picfile.ShowDialog() == DialogResult.OK)
            {
                txt_addpic.Text = picfile.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(cbx_spelling.Checked==true)
            {
                // בדיקה שכל השדות מלאים
                if(txt_addword.Text.Length !=0&&txt_addsound.Text.Length != 0 && txt_wrong1.Text.Length != 0 && txt_wrong2.Text.Length != 0 && txt_wrong3.Text.Length != 0)
                {
                    bool exist = false;
                    for(int i =0;i< spellingwords.Count ;i++)
                    {
                        if(spellingwords[i].word==txt_addword.Text)
                        {
                            MessageBox.Show("the word you are trying to enter allready exist in the data base");
                            exist = true;
                            break;
                        }
                    }
                    if (exist==false)
                    {
                        try
                        {
                            File.Copy(txt_addsound.Text, @"C:\Users\almog\source\repos\WindowsFormsApp1\bin\Debug\VOICE\"+txt_addword.Text+".wav");//צריך לפתור את הבעיה שהבודק אין לו את אותן תיקיות כמו במחשב שלי
                            int index = spellingwords.Count + 1;
                            WordWSpelling nw = new WordWSpelling(txt_wrong1.Text, txt_wrong2.Text, txt_wrong3.Text, txt_addword.Text, spellingwords.Count + 1, txt_addword.Text + ".wav");
                            string st = index + ";" + txt_addword.Text + ";" + txt_addword.Text + ".wav;" + txt_wrong1.Text + ";" + txt_wrong2.Text + ";" + txt_wrong3.Text;//יצירת משפט לכתוב לתוך הקובץ
                            spellingwords.Add(nw);//  העברת הנתונים שהמתמש רשם לאובייקט והכנסת האובייקט החדש לתוך רשימת המילים לאיות 
                            using (StreamWriter newword = new StreamWriter(@"C:\Users\almog\source\repos\WindowsFormsApp1\bin\Debug\DATA\SpellWords.txt", true))
                            { newword.WriteLine("\r\n"+st); }
                        }
                        catch (IOException copyError)
                        {
                            MessageBox.Show("error copying the media into the date");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("you need all the txt boxes to be filled");
                }
            }
            else if (cbx_games.Checked  == true)
            {
                if (txt_addword.Text.Length != 0 && txt_addsound.Text.Length != 0 && txt_addword.Text.Length!=0)
                {
                    bool exist = false;
                    for (int i = 0; i < gamewords.Count; i++)
                    {
                        if (gamewords[i].word == txt_addword.Text)
                        {
                            MessageBox.Show("the word you are trying to enter allready exist in the data base");
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        try
                        {
                            File.Copy(txt_addsound.Text, @"C:\Users\almog\source\repos\WindowsFormsApp1\bin\Debug\VOICE\" + txt_addword.Text + ".wav");//צריך לפתור את הבעיה שהבודק אין לו את אותן תיקיות כמו במחשב שלי
                            File.Copy(txt_addpic.Text, @"C:\Users\almog\source\repos\WindowsFormsApp1\bin\Debug\DIMAGES\" + txt_addword.Text + ".jpg");//צריך לפתור את הבעיה שהבודק אין לו את אותן תיקיות כמו במחשב שלי
                            int index = gamewords.Count + 1, i = 0;
                            char[] letters = new char[txt_addword.Text.Length];
                            foreach (char leter in txt_addword.Text)
                            {
                                letters[i] = leter;
                                i++;
                            }
                            WordWImage nw = new WordWImage(txt_addword.Text + ".jpg", txt_addword.Text.Length, letters, txt_addword.Text, spellingwords.Count + 1, txt_addword.Text + ".wav");
                            string tmp = "";
                            foreach (char letter in letters) { tmp = tmp + ";" + letter; };
                            string st = index + ";" + txt_addword.Text + ";" + txt_addword.Text + ".jpg;" + txt_addword.Text + ".wav;" + tmp;//יצירת משפט לכתוב לתוך הקובץ
                            gamewords.Add(nw);//  העברת הנתונים שהמתמש רשם לאובייקט והכנסת האובייקט החדש לתוך רשימת המילים לאיות 
                            using (StreamWriter newword = new StreamWriter(@"C:\Users\almog\source\repos\WindowsFormsApp1\bin\Debug\DATA\wordImageData.txt", true))
                            {newword.WriteLine("\r\n"+st);} 
                        }
                        catch (IOException copyError)
                        {
                            MessageBox.Show("error copying the media into the date");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("you need all the txt boxes to be filled");
                }
            }
        }
    }
}
