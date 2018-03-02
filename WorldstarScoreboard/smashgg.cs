using System.Collections.Generic;
namespace S3 { 
    public class smashgg
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
            public string description { get; set; }
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
            public List<string> platformIds { get; set; }
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
            public bool checkInEnabled { get; set; }
            public int checkInDuration { get; set; }
            public int checkInBuffer { get; set; }
            public object deadlineAction { get; set; }
            public int startAt { get; set; }
            public int endAt { get; set; }
            public object startedAt { get; set; }
            public object completedAt { get; set; }
            public object projectionMode { get; set; }
            public object rulesetId { get; set; }
            public object requiresVerification { get; set; }
            public PageConfig pageConfig { get; set; }
            public List<object> gameModeConfig { get; set; }
            public List<object> rulesetSettings { get; set; }
            public object deckSubmissionDeadline { get; set; }
            public bool deckDeadlineHandled { get; set; }
            public List<object> stations { get; set; }
            public List<object> streams { get; set; }
            public List<object> waves { get; set; }
            public List<object> publishing { get; set; }
            public List<object> images { get; set; }
            public int scheduleId { get; set; }
            public object platform { get; set; }
            public List<string> expand { get; set; }
            public string typeDisplayStr { get; set; }
        }

        public class Entrant
        {
            public object isPlaceholder { get; set; }
            public int id { get; set; }
            public int eventId { get; set; }
            public List<int> participantIds { get; set; }
            public object participant1Id { get; set; }
            public object participant2Id { get; set; }
            public string name { get; set; }
            public int? finalPlacement { get; set; }
            public int defaultSkill { get; set; }
            public object skill { get; set; }
            public int skillOrder { get; set; }
            public bool unverified { get; set; }
            public object placement { get; set; }
        }

        public class Entities
        {
            public Event @event { get; set; }
            public List<Entrant> entrants { get; set; }
        }

        public class Update
        {
            public List<int> entrants { get; set; }
        }

        public class UpdateBigquery
        {
            public List<int> entrants { get; set; }
        }

        public class ActionRecords
        {
            public Update update { get; set; }
            public UpdateBigquery update_bigquery { get; set; }
        }

        public class RootObject
        {
            public Entities entities { get; set; }
            public int result { get; set; }
            public string resultEntity { get; set; }
            public ActionRecords actionRecords { get; set; }
        }
    }
}