using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker
{
    class GroupData
    {
        public class Stats
        {
            public string title { get; set; }
            public string path { get; set; }
            public List<object> config { get; set; }
        }

        public class Tabs
        {
            public Stats stats { get; set; }
        }

        public class PageConfig
        {
            public List<object> header { get; set; }
            public Tabs tabs { get; set; }
            public object rules { get; set; }
        }

        public class Event
        {
            public int id { get; set; }
            public int tournamentId { get; set; }
            public int state { get; set; }
            public int progressMeter { get; set; }
            public int videogameId { get; set; }
            public string name { get; set; }
            public object description { get; set; }
            public string slug { get; set; }
            public int entryFee { get; set; }
            public object entryCap { get; set; }
            public int entrantSizeMin { get; set; }
            public int entrantSizeMax { get; set; }
            public int requiredCheckinNum { get; set; }
            public bool teamNameAllowed { get; set; }
            public object teamManagementDeadline { get; set; }
            public bool allowAutoReport { get; set; }
            public object tmgEventType { get; set; }
            public object templateId { get; set; }
            public object gameName { get; set; }
            public object playersPerEntry { get; set; }
            public object exhibition { get; set; }
            public object networkIds { get; set; }
            public object platformIds { get; set; }
            public object version { get; set; }
            public int type { get; set; }
            public int formatType { get; set; }
            public int teamsFormat { get; set; }
            public int entrantMode { get; set; }
            public bool @private { get; set; }
            public bool isOnline { get; set; }
            public bool hasTasks { get; set; }
            public bool hasDecks { get; set; }
            public bool enableSlippi { get; set; }
            public bool hasMatchmaking { get; set; }
            public bool isPlaceholder { get; set; }
            public int startAt { get; set; }
            public int endAt { get; set; }
            public object startedAt { get; set; }
            public object completedAt { get; set; }
            public object projectionMode { get; set; }
            public object rulesetId { get; set; }
            public PageConfig pageConfig { get; set; }
            public List<object> gameModeConfig { get; set; }
            public List<object> rulesetSettings { get; set; }
            public List<object> stations { get; set; }
            public List<object> streams { get; set; }
            public List<object> waves { get; set; }
            public List<object> publishing { get; set; }
            public List<object> images { get; set; }
            public int scheduleId { get; set; }
            public object platform { get; set; }
            public object requiresVerification { get; set; }
            public List<string> expand { get; set; }
            public string typeDisplayStr { get; set; }
        }

        public class Group
        {
            public int id { get; set; }
            public int phaseId { get; set; }
            public object waveId { get; set; }
            public object poolRefId { get; set; }
            public int groupTypeId { get; set; }
            public object title { get; set; }
            public string identifier { get; set; }
            public string displayIdentifier { get; set; }
            public int state { get; set; }
            public object tiebreakOrder { get; set; }
            public object tiebreaks { get; set; }
            public object bestOf { get; set; }
            public int setsOnDeck { get; set; }
            public int rematchSeconds { get; set; }
            public bool finalized { get; set; }
            public object winnersTargetPhaseId { get; set; }
            public int numProgressing { get; set; }
            public object losersTargetPhaseId { get; set; }
            public object startAt { get; set; }
            public object startedAt { get; set; }
            public List<object> seeds { get; set; }
            public List<object> sets { get; set; }
            public List<object> rounds { get; set; }
            public object numRounds { get; set; }
            public object pointsPerMatchWin { get; set; }
            public object pointsPerGameWin { get; set; }
            public object pointsPerBye { get; set; }
            public bool matchmakingEnabled { get; set; }
            public int scheduleId { get; set; }
            public List<object> expand { get; set; }
            public bool hasSets { get; set; }
            public bool hasCustomWinnerByes { get; set; }
        }

        public class Entities
        {
            public Event @event { get; set; }
            public List<Group> groups { get; set; }
        }

        public class RootObject
        {
            public Entities entities { get; set; }
            public int result { get; set; }
            public string resultEntity { get; set; }
            public List<object> actionRecords { get; set; }
        }
    }
}