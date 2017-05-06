using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Ticker.GroupData;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Ticker
{
    class Ticker
    {
        public static List<string> matches = new List<string>();

        public static Boolean IsValid(int? p1, int? p2, int? score1, int? score2)
        {
            if(p1 == null || p2 == null || score1 == null || score2 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int GetWinner(int? p1, int? p2, int? winner)
        {
            if (winner == p1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static void WriteMatch(int? p1, int? p2, int? win, int? score1, int? score2)
        {
            int winner = GetWinner(p1, p2, win);
            Boolean valid = IsValid(p1, p2, score1, score2);
            if(valid == false)
            {
                return;
            }
            try
            {
                string p1tag = S3.MainForm.entranthash[p1];
                string p2tag = S3.MainForm.entranthash[p2];
                if (winner == 1)
                {

                    matches.Add("<div class=\"left\"><b><div class=\"score1\">" + score1 + "</div> <div class=\"tag1\">" + p1tag + "</div></b></div> <div class=\"right\"><div class=\"tag2\"><p>" + p2tag + "</p></div> <div class=\"score2\"><p>" + score2 + "</p></div></div>");
                }
                else
                {
                    matches.Add("<div class=\"left\"><div class=\"score1\">" + score2 + "</div> <div class=\"tag1\">" + p2tag + "</div></b></div> <div class=\"right\"><div class=\"tag2\"><p>" + p1tag + "</p></div> <div class=\"score2\"><p>" + score1 + "</p></div></div>");
                }

            }
            catch (KeyNotFoundException e){
                return;
            }
            
        }
        public static void GetSets()
        {
            List<int> ids = new List<int>();
            string smashgg = S3.Globals.settings.smashgg;
            if (smashgg == null)
            {
                return;
            }
            else
            {

                string url = "https://api.smash.gg/tournament/" + smashgg + "/event/melee-singles?expand[0]=groups";
                var json = new WebClient().DownloadString(url);
                GroupData.RootObject data = JsonConvert.DeserializeObject<GroupData.RootObject>(json);
                foreach (var group in data.entities.groups)
                {
                    int groupid = group.id;
                    ids.Add(groupid);
                }
            }
            for (var i = 0; i < ids.Count; i++)
            {
                {
                    int phaseGroupId = ids[i];
                    string url = "https://api.smash.gg/phase_group/" + phaseGroupId + "?expand[]=sets";
                    var jsonstring = new WebClient().DownloadString(url);
                    SetData.RootObject data = JsonConvert.DeserializeObject<SetData.RootObject>(jsonstring);
                    foreach (var set in data.entities.sets)
                    {
                        int? entrant1id = set.entrant1Id;
                        int? entrant2id = set.entrant2Id;
                        int? winnerid = set.winnerId;
                        int? entrant1score = set.entrant1Score;
                        int? entrant2score = set.entrant2Score;
                        WriteMatch(entrant1id, entrant2id, winnerid, entrant1score, entrant2score);
                    }
                }
            }
        }
    }
}
