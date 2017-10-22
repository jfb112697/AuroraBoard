using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Ticker
{
    class Ticker
    {
        private static bool match(string a, string b)
        {
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public static Set getStreamStatus(string smashgg)
        {
            int streamId = S3.Globals.settings.streamId;
            List<Set> Sets = new List<Set>();
            string url = "https://api.smash.gg/tournament/" + smashgg + "/event/melee-singles?expand[0]=groups";
            var json = new WebClient().DownloadString(url);
            dynamic RootObject = JObject.Parse(json);

            List<int> phaseIds = new List<int>();
            var groups = RootObject.entities.groups;
            foreach (var group in groups)
            {
                int phaseId = group.id;
                string phaseUrl = "https://api.smash.gg/phase_group/" + phaseId + "?expand[]=sets";
                var phaseJson = new WebClient().DownloadString(phaseUrl);
                dynamic PhaseObject = JObject.Parse(phaseJson);
                var sets = PhaseObject.entities.sets;
                foreach (var set in sets)
                {
                    if (set.streamId == streamId)
                    {
                        int? entrant1 = set.entrant1Id;
                        int? entrant2 = set.entrant2Id;
                        int? score1 = set.entrant1Score;
                        int? score2 = set.entrant2Score;
                        int? completed = set.completedAt;
                        string round = set.fullRoundText;

                        Set gameSet = new Set(entrant1, entrant2, score1, score2, round);
                        if (gameSet.isValid() && completed == null)
                        {
                            return gameSet;
                        }
                    }
                }
            }
            return null;
        }
        public static List<Set> getSets(string smashgg)
        {
            List<Set> Sets = new List<Set>();
            string url = "https://api.smash.gg/tournament/" + smashgg + "/event/melee-singles?expand[0]=groups";
            var json = new WebClient().DownloadString(url);
            dynamic RootObject = JObject.Parse(json);

            List<int> phaseIds = new List<int>();
            var groups = RootObject.entities.groups;
            foreach(var group in groups)
            {
                int phaseId = group.id;
                phaseIds.Add(phaseId);
            }
            for(int i = phaseIds.Count - 1; i >= 0 ; i--)
            {
                string phaseUrl = "https://api.smash.gg/phase_group/" + phaseIds[i] + "?expand[]=sets";
                var phaseJson = new WebClient().DownloadString(phaseUrl);

                dynamic PhaseObject = JObject.Parse(phaseJson);
                var sets = PhaseObject.entities.sets;
                foreach(var set in sets)
                {
                    int? entrant1 = set.entrant1Id;
                    int? entrant2 = set.entrant2Id;
                    int? score1 = set.entrant1Score;
                    int? score2 = set.entrant2Score;
                    int? completed = set.completedAt;

                    Set gameSet = new Set(entrant1, entrant2, score1, score2, completed);


                    if (gameSet.isValid() && completed != null)
                    {
                        Sets.Add(gameSet);
                    }
                }
            }
            List<Set> SortedList = Sets.OrderBy(Set => Set.completed).ToList();
            return SortedList;

        }
    }
}