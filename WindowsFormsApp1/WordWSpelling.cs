using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exam
{
    public class WordWSpelling : Word, IComparable
    {
        public string wrong1;
        public string wrong2;
        public string wrong3;
        static int wordwspellingcounter = 130;
        public WordWSpelling(string wrong1, string wrong2, string wrong3, string word, int wordid, string wordwav) : base(word, wordid, wordwav)
        {
            this.wrong1 = wrong1;
            this.wrong2 = wrong2; 
            this.wrong3 = wrong3;
        }
        public int CompareTo(object obj)// מתודה שמשווה בין שניי אובייקטים של ה class
        {
            if (!(obj is WordWSpelling))
                throw new Exception("Object is not a WordWSpelling, can not compare!!");

            WordWSpelling w = (WordWSpelling)obj;
            if (wordid == w.wordid) return 0;
            if (wordid < w.wordid) return -1;
            else return 1; // id > p.id
        }
    }
}
