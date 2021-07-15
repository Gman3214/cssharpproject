using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exam
{
    public class Word /*: IComparable*/ 
    {
        public string word;
        public int wordid;
        public string wordwav; 

        public Word(string word, int wordid, string wordwav)
        {
            this.word = word;
            this.wordid = wordid;
            this.wordwav = wordwav;
        }
        //public static bool operator == (Word lf, Word rf)
        //{
        //    return lf.Equals(rf);
        //}
        //public static bool operator !=(Word lf, Word rf)
        //{
        //    return !(lf.Equals(rf));
        //}
    }
}
