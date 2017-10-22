using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker
{
    class SetData
    {
        public class Groups
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
            public int winnersTargetPhaseId { get; set; }
            public int numProgressing { get; set; }
            public object losersTargetPhaseId { get; set; }
            public object startAt { get; set; }
            public object startedAt { get; set; }
            public List<object> seeds { get; set; }
            public List<object> sets { get; set; }
            public List<object> rounds { get; set; }
            public object numRounds { get; set; }
            public object firstRoundTime { get; set; }
            public bool canAutoAssign { get; set; }
            public bool autoAssigning { get; set; }
            public bool runOnce { get; set; }
            public bool callMatches { get; set; }
            public bool applyAll { get; set; }
            public int pointsPerMatchWin { get; set; }
            public int pointsPerGameWin { get; set; }
            public int pointsPerBye { get; set; }
            public bool matchmakingEnabled { get; set; }
            public int scheduleId { get; set; }
            public object tiebreakOrderTemp { get; set; }
            public List<string> expand { get; set; }
            public bool hasSets { get; set; }
            public bool hasCustomWinnerByes { get; set; }
        }

        public class Set
        {
            public string id { get; set; }
            public int eventId { get; set; }
            public int phaseGroupId { get; set; }
            public object stationId { get; set; }
            public object streamId { get; set; }
            public int? entrant1Id { get; set; }
            public int? entrant2Id { get; set; }
            public int? winnerId { get; set; }
            public object loserId { get; set; }
            public string bracketId { get; set; }
            public string entrant1PrereqType { get; set; }
            public object entrant1PrereqId { get; set; }
            public string entrant1PrereqCondition { get; set; }
            public string entrant2PrereqType { get; set; }
            public object entrant2PrereqId { get; set; }
            public string entrant2PrereqCondition { get; set; }
            public int? wProgressionSeedId { get; set; }
            public object lProgressionSeedId { get; set; }
            public int? wPlacement { get; set; }
            public int? lPlacement { get; set; }
            public object wOverallPlacement { get; set; }
            public object lOverallPlacement { get; set; }
            public object lEligiblePhaseId { get; set; }
            public object wEligiblePhaseId { get; set; }
            public bool unreachable { get; set; }
            public bool isTiebreak { get; set; }
            public int type { get; set; }
            public object crewPlayerCount { get; set; }
            public string identifier { get; set; }
            public int round { get; set; }
            public int state { get; set; }
            public int? entrant1Score { get; set; }
            public int? entrant2Score { get; set; }
            public int bestOf { get; set; }
            public int totalGames { get; set; }
            public int setGamesType { get; set; }
            public bool isLast { get; set; }
            public bool isGF { get; set; }
            public bool hasPlaceholder { get; set; }
            public bool entrant1Present { get; set; }
            public bool entrant2Present { get; set; }
            public object adminViewedBy { get; set; }
            public object adminMessagedBy { get; set; }
            public object tasksPruned { get; set; }
            public List<object> subState { get; set; }
            public object modRequestedBy { get; set; }
            public object modRequestedAt { get; set; }
            public object vodUrl { get; set; }
            public object fbUrl { get; set; }
            public object smashggUrl { get; set; }
            public object durationSeconds { get; set; }
            public int updatedAt { get; set; }
            public object updatedAtMicro { get; set; }
            public object startAt { get; set; }
            public object startedAt { get; set; }
            public int? completedAt { get; set; }
            public object adminViewedAt { get; set; }
            public object adminMessagedAt { get; set; }
            public object progressionPlacement { get; set; }
            public object progressionCount { get; set; }
            public List<object> games { get; set; }
            public int videogameId { get; set; }
            public int eventType { get; set; }
            public List<object> images { get; set; }
            public int previewOrder { get; set; }
            public List<string> expand { get; set; }
            public int displayRound { get; set; }
            public int originalRound { get; set; }
            public string fullRoundText { get; set; }
            public string midRoundText { get; set; }
            public string shortRoundText { get; set; }
            public object roundDivision { get; set; }
            public string entrant1PrereqStr { get; set; }
            public string entrant2PrereqStr { get; set; }
            public int? wProgressingPhaseGroupId { get; set; }
            public int? wProgressingPhaseId { get; set; }
            public string wProgressingName { get; set; }
        }

        public class Entities
        {
            public Groups groups { get; set; }
            public List<Set> sets { get; set; }
            public List<object> stat { get; set; }
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
