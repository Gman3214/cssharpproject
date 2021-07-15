using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exam
{
    public class User
    {
        public string mail;
        public string username;
        public int genralscore;
        public List<int> wrongamewords = new List<int>();

        public User()
		{
            mail = null;
            username = null;
            genralscore = 0;
            wrongamewords = null;
		}
        public User (string mail)
        {
            this.mail = mail;
            string name=null;
            foreach (char letter in mail) //חילוץ שם משתמש מהאימייל (לבדוק שזה באמת עובד
            {
                if (letter != '@')
                    name = name + letter;
                else
                    break;
            }
            username = name;
            loadwrongfromfile(username);
            genralscore = 0;
        }
        public void scoreupdate (int points)// מעדכן את הציון הכללי של המשתמש
        {
            genralscore = genralscore + points; 
        }
        
        private void loadwrongfromfile(string name)
		{
            if(File.Exists(@"OUTPUT\" + name + "_wrong.txt"))
			{
                using (StreamReader sr = new StreamReader(@"OUTPUT\" + name + "_wrong.txt"))
                {
                    string str = null;
                    if (sr.ReadLine() == null)
                        return;
                    while ((str = sr.ReadLine()) != null)
                        wrongamewords.Add(int.Parse(str));
                }
            }

        }
        public void addwrong(List<int> wrongslist)
		{
            for (int i = 0; i < wrongslist.Count; i++)
                wrongamewords.Add(wrongslist[i]);
		}
        public void fileupdate (string location, int id)//מעדכן את הקובץ המתאים בכל פעם שהמשתמש צודק או טועה באיות
        {
            StreamWriter sw = new StreamWriter(@location);
            sw.WriteLine(id + "\r\n"); // לבדוק שזה רושם נכון בקובץ
            sw.Close();
        }
    }

}
