using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Ticker
{
    class Set
    {
        public int? entrant1 { get; set; }
        public int? entrant2 { get; set; }
        public int? score1 { get; set; }
        public int? score2 { get; set; }
        internal int? completed { get; set; }
        public string round { get; set; }
        
        public Set(int? e1, int? e2, int? s1, int? s2, string roundtext)
        {
            if(s1 == null)
            {
                s1 = 0;
            }
            if (s2 == null)
            {
                s2 = 0;
            }
            entrant1 = e1;
            entrant2 = e2;
            score1 = s1;
            score2 = s2;
            round = roundtext;
        }
        public Set(int? e1, int? e2, int? s1, int? s2, int? comp)
        {
            entrant1 = e1;
            entrant2 = e2;
            score1 = s1;
            score2 = s2;
            completed = comp;
        }

        private int getWinner()
        {
            if(score1 > score2)
            {
                return 1;
            }
            else if(score2 > score1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public string[] getTags()
        {
            string p1tag = S3.MainForm.entranthash[entrant1];
            string p2tag = S3.MainForm.entranthash[entrant2];
            string[] tags = new string[2] { p1tag, p2tag };
            return tags;
        }
        public string toString()
        {
            string[] tags = getTags();
            int winner = getWinner();
            if (winner == 1)
            {
                return("<div class=\"left\"><b><div class=\"score1\">" + score1 + "</div> <div class=\"tag1\">" + tags[0] + "</div></b></div> <div class=\"right\"><div class=\"tag2\"><p>" + tags[1] + "</p></div> <div class=\"score2\"><p>" + score2 + "</p></div></div>");
            }
            else
            {
                return("<div class=\"left\"><b><div class=\"score1\">" + score2 + "</div> <div class=\"tag1\">" + tags[1] + "</div></b></div> <div class=\"right\"><div class=\"tag2\"><p>" + tags[0] + "</p></div> <div class=\"score2\"><p>" + score1 + "</p></div></div>");
            }
        }
        public bool isValid()
        {
            if(entrant1 == null || entrant2 == null || score1 < 0 || score2 < 0 || score1 == null || score2 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
