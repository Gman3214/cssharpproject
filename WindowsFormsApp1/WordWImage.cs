using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exam
{
    public class WordWImage : Word , IComparable 
    {
        public string wordimg;
        public int wordlng;
        public char[] letters; 
        static int wordwimagecounter = 130;

        public WordWImage (string wordimg, int wordlng, char[] letters, string word, int wordid, string wordwav) : base( word, wordid, wordwav)
        {
            this.wordimg = wordimg;
            this.wordlng = wordlng;
            this.letters = letters;
        }
        public int CompareTo(object obj)// מתודה שמשווה בין שניי אובייקטים של ה class
        {
            if (!(obj is WordWImage ))
                throw new Exception("Object is not a wordwimage, can not compare!!");

            WordWImage w = (WordWImage)obj;
            if (wordid == w.wordid ) return 0;
            if (wordid  < w.wordid ) return -1;
            else return 1; // id > p.id
        }

    }
}
