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
            genralscore = 0;
        }
        public void scoreupdate (int points)// מעדכן את הציון הכללי של המשתמש
        {
            genralscore = genralscore + points; 
        }
        public void fileupdate (string location, int id)//מעדכן את הקובץ המתאים בכל פעם שהמשתמש צודק או טועה באיות
        {
            StreamWriter sw = new StreamWriter(@location);
            sw.WriteLine(id + "\r\n"); // לבדוק שזה רושם נכון בקובץ
            sw.Close();
        }
    }

}
