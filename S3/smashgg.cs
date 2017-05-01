using System.Collections.Generic;
namespace S3 { 
public class smashgg
{

        public class NameFirst
        {
            public bool visible { get; set; }
            public bool required { get; set; }
        }

        public class NameLast
        {
            public bool visible { get; set; }
            public bool required { get; set; }
        }

        public class PhoneNumber
        {
            public bool visible { get; set; }
            public bool required { get; set; }
        }

        public class AttendeeFieldConfig
        {
            public NameFirst nameFirst { get; set; }
            public NameLast nameLast { get; set; }
            public PhoneNumber phoneNumber { get; set; }
        }

        public class Seeding
        {
            public bool __invalid_name__129981 { get; set; }
            public bool __invalid_name__129982 { get; set; }
            public bool __invalid_name__132042 { get; set; }
        }

        public class Bracket
        {
            public bool __invalid_name__129981 { get; set; }
            public bool __invalid_name__129982 { get; set; }
            public bool __invalid_name__132042 { get; set; }
        }

        public class Publishing
        {
            public bool publish { get; set; }
            public bool registration { get; set; }
            public bool attendees { get; set; }
            public Seeding seeding { get; set; }
            public Bracket bracket { get; set; }
            public bool live { get; set; }
            public bool fantasy { get; set; }
            public bool testmode { get; set; }
            public string pools_ordering { get; set; }
        }

        public class Image
        {
            public int id { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int ratio { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public bool isOriginal { get; set; }
            public object entity { get; set; }
            public object entityId { get; set; }
            public object uploadedBy { get; set; }
            public object createdAt { get; set; }
            public object updatedAt { get; set; }
        }

        public class Tournament
        {
            public int id { get; set; }
            public object seriesId { get; set; }
            public int ownerId { get; set; }
            public int state { get; set; }
            public int progressMeter { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string shortSlug { get; set; }
            public int venueFee { get; set; }
            public int processingFee { get; set; }
            public object tiebreakOrder { get; set; }
            public string timezone { get; set; }
            public bool @private { get; set; }
            public bool published { get; set; }
            public bool testMode { get; set; }
            public bool publicSeeding { get; set; }
            public int tournamentType { get; set; }
            public bool hasOnlineEvents { get; set; }
            public bool includeQRCode { get; set; }
            public bool approved { get; set; }
            public int startAt { get; set; }
            public int endAt { get; set; }
            public object startedAt { get; set; }
            public object completedAt { get; set; }
            public object registrationClosesAt { get; set; }
            public object eventRegistrationClosesAt { get; set; }
            public object teamCreationClosesAt { get; set; }
            public string stripeMode { get; set; }
            public string paypalMode { get; set; }
            public string paypalApp { get; set; }
            public object city { get; set; }
            public string addrState { get; set; }
            public string postalCode { get; set; }
            public string countryCode { get; set; }
            public string mapsPlaceId { get; set; }
            public object lat { get; set; }
            public object lng { get; set; }
            public List<object> links { get; set; }
            public string venueName { get; set; }
            public string venueAddress { get; set; }
            public int region { get; set; }
            public string hashtag { get; set; }
            public object showCity { get; set; }
            public int attendeeLocationInfo { get; set; }
            public int attendeeContactInfo { get; set; }
            public AttendeeFieldConfig attendeeFieldConfig { get; set; }
            public object attendeeRequirements { get; set; }
            public bool notifyAdmins { get; set; }
            public bool publicAttendees { get; set; }
            public bool hideAdmins { get; set; }
            public object videoUrl { get; set; }
            public string details { get; set; }
            public object registrationMarkdown { get; set; }
            public string gettingThere { get; set; }
            public object prizes { get; set; }
            public object rules { get; set; }
            public object contactInfo { get; set; }
            public bool includeInstructions { get; set; }
            public object emailInstructions { get; set; }
            public bool includeDirections { get; set; }
            public object emailDirections { get; set; }
            public bool includeMap { get; set; }
            public object qrCodeRedirect { get; set; }
            public object emailNote { get; set; }
            public bool includeNote { get; set; }
            public object contactEmail { get; set; }
            public object contactTwitter { get; set; }
            public object contactPhone { get; set; }
            public string currency { get; set; }
            public object onsitePaymentMode { get; set; }
            public string stripePublishableKey { get; set; }
            public string paypalPayerId { get; set; }
            public object customEmailText { get; set; }
            public List<object> registrationOptions { get; set; }
            public List<object> limitsByType { get; set; }
            public Publishing publishing { get; set; }
            public List<object> trackingPixels { get; set; }
            public object generatedTabs { get; set; }
            public string defaultTab { get; set; }
            public List<object> fees { get; set; }
            public List<object> customMarkdown { get; set; }
            public List<Image> images { get; set; }
            public int scheduleId { get; set; }
            public List<string> expand { get; set; }
            public List<object> userData { get; set; }
            public string regionDisplayName { get; set; }
            public List<object> onlineEvents { get; set; }
            public List<object> taskEvents { get; set; }
            public List<string> slugs { get; set; }
            public string permissionType { get; set; }
            public bool supportsPayPal { get; set; }
        }

        public class PlayerIds
        {
            public int __invalid_name__709678 { get; set; }
            public int? __invalid_name__709681 { get; set; }
            public int? __invalid_name__709801 { get; set; }
            public int? __invalid_name__709888 { get; set; }
            public int? __invalid_name__712724 { get; set; }
            public int? __invalid_name__713482 { get; set; }
            public int? __invalid_name__714216 { get; set; }
            public int? __invalid_name__714255 { get; set; }
            public int? __invalid_name__714284 { get; set; }
            public int? __invalid_name__714767 { get; set; }
            public int? __invalid_name__715482 { get; set; }
            public int? __invalid_name__718331 { get; set; }
            public int? __invalid_name__718571 { get; set; }
            public int? __invalid_name__719062 { get; set; }
            public int? __invalid_name__722959 { get; set; }
            public int? __invalid_name__725656 { get; set; }
            public int? __invalid_name__727289 { get; set; }
            public int? __invalid_name__727880 { get; set; }
            public int? __invalid_name__728615 { get; set; }
            public int? __invalid_name__728753 { get; set; }
            public int? __invalid_name__728894 { get; set; }
            public int? __invalid_name__729292 { get; set; }
            public int? __invalid_name__729372 { get; set; }
            public int? __invalid_name__729391 { get; set; }
            public int? __invalid_name__729407 { get; set; }
            public int? __invalid_name__729514 { get; set; }
            public int? __invalid_name__729555 { get; set; }
            public int? __invalid_name__729703 { get; set; }
            public int? __invalid_name__729707 { get; set; }
            public int? __invalid_name__730288 { get; set; }
            public int? __invalid_name__730524 { get; set; }
            public int? __invalid_name__730992 { get; set; }
            public int? __invalid_name__731319 { get; set; }
            public int? __invalid_name__731599 { get; set; }
            public int? __invalid_name__731989 { get; set; }
            public int? __invalid_name__732009 { get; set; }
            public int? __invalid_name__732848 { get; set; }
            public int? __invalid_name__733245 { get; set; }
            public int? __invalid_name__733455 { get; set; }
            public int? __invalid_name__734952 { get; set; }
            public int? __invalid_name__735002 { get; set; }
            public int? __invalid_name__735079 { get; set; }
            public int? __invalid_name__735095 { get; set; }
            public int? __invalid_name__735965 { get; set; }
            public int? __invalid_name__736674 { get; set; }
            public int? __invalid_name__737073 { get; set; }
            public int? __invalid_name__737185 { get; set; }
            public int? __invalid_name__737387 { get; set; }
            public int? __invalid_name__737571 { get; set; }
            public int? __invalid_name__737892 { get; set; }
            public int? __invalid_name__738337 { get; set; }
            public int? __invalid_name__738659 { get; set; }
            public int? __invalid_name__738660 { get; set; }
            public int? __invalid_name__738661 { get; set; }
            public int? __invalid_name__738669 { get; set; }
            public int? __invalid_name__738689 { get; set; }
            public int? __invalid_name__738712 { get; set; }
            public int? __invalid_name__738728 { get; set; }
            public int? __invalid_name__738902 { get; set; }
            public int? __invalid_name__738991 { get; set; }
            public int? __invalid_name__739014 { get; set; }
            public int? __invalid_name__739115 { get; set; }
            public int? __invalid_name__739143 { get; set; }
            public int? __invalid_name__739193 { get; set; }
            public int? __invalid_name__739247 { get; set; }
            public int? __invalid_name__740409 { get; set; }
            public int? __invalid_name__740432 { get; set; }
            public int? __invalid_name__740676 { get; set; }
            public int? __invalid_name__740751 { get; set; }
            public int? __invalid_name__740802 { get; set; }
            public int? __invalid_name__741026 { get; set; }
            public int? __invalid_name__741045 { get; set; }
            public int? __invalid_name__741066 { get; set; }
            public int? __invalid_name__741094 { get; set; }
            public int? __invalid_name__741138 { get; set; }
            public int? __invalid_name__741152 { get; set; }
            public int? __invalid_name__741171 { get; set; }
            public int? __invalid_name__741203 { get; set; }
            public int? __invalid_name__741232 { get; set; }
            public int? __invalid_name__741574 { get; set; }
            public int? __invalid_name__742191 { get; set; }
            public int? __invalid_name__742291 { get; set; }
            public int? __invalid_name__742566 { get; set; }
            public int? __invalid_name__742586 { get; set; }
            public int? __invalid_name__742633 { get; set; }
            public int? __invalid_name__742712 { get; set; }
            public int? __invalid_name__742714 { get; set; }
            public int? __invalid_name__742723 { get; set; }
            public int? __invalid_name__742784 { get; set; }
            public int? __invalid_name__742825 { get; set; }
            public int? __invalid_name__742969 { get; set; }
            public int? __invalid_name__742970 { get; set; }
            public int? __invalid_name__742985 { get; set; }
            public int? __invalid_name__743057 { get; set; }
            public int? __invalid_name__743079 { get; set; }
            public int? __invalid_name__743120 { get; set; }
            public int? __invalid_name__743138 { get; set; }
            public int? __invalid_name__743178 { get; set; }
            public int? __invalid_name__743219 { get; set; }
            public int? __invalid_name__743341 { get; set; }
            public int? __invalid_name__743344 { get; set; }
            public int? __invalid_name__743352 { get; set; }
            public int? __invalid_name__743357 { get; set; }
            public int? __invalid_name__743703 { get; set; }
        }

        public class Prefixes
        {
            public string __invalid_name__709678 { get; set; }
            public object __invalid_name__709681 { get; set; }
            public object __invalid_name__709801 { get; set; }
            public string __invalid_name__709888 { get; set; }
            public object __invalid_name__712724 { get; set; }
            public string __invalid_name__713482 { get; set; }
            public object __invalid_name__714216 { get; set; }
            public object __invalid_name__714255 { get; set; }
            public string __invalid_name__714284 { get; set; }
            public object __invalid_name__714767 { get; set; }
            public object __invalid_name__715482 { get; set; }
            public object __invalid_name__718331 { get; set; }
            public string __invalid_name__718571 { get; set; }
            public string __invalid_name__719062 { get; set; }
            public object __invalid_name__722959 { get; set; }
            public object __invalid_name__725656 { get; set; }
            public object __invalid_name__727289 { get; set; }
            public object __invalid_name__727880 { get; set; }
            public string __invalid_name__728615 { get; set; }
            public string __invalid_name__728753 { get; set; }
            public object __invalid_name__728894 { get; set; }
            public object __invalid_name__729292 { get; set; }
            public object __invalid_name__729372 { get; set; }
            public object __invalid_name__729391 { get; set; }
            public object __invalid_name__729407 { get; set; }
            public string __invalid_name__729514 { get; set; }
            public object __invalid_name__729555 { get; set; }
            public object __invalid_name__729703 { get; set; }
            public string __invalid_name__729707 { get; set; }
            public string __invalid_name__730288 { get; set; }
            public object __invalid_name__730524 { get; set; }
            public object __invalid_name__730992 { get; set; }
            public object __invalid_name__731319 { get; set; }
            public object __invalid_name__731599 { get; set; }
            public object __invalid_name__731989 { get; set; }
            public object __invalid_name__732009 { get; set; }
            public object __invalid_name__732848 { get; set; }
            public string __invalid_name__733245 { get; set; }
            public object __invalid_name__733455 { get; set; }
            public object __invalid_name__734952 { get; set; }
            public object __invalid_name__735002 { get; set; }
            public string __invalid_name__735079 { get; set; }
            public string __invalid_name__735095 { get; set; }
            public object __invalid_name__735965 { get; set; }
            public object __invalid_name__736674 { get; set; }
            public object __invalid_name__737073 { get; set; }
            public object __invalid_name__737185 { get; set; }
            public object __invalid_name__737387 { get; set; }
            public object __invalid_name__737571 { get; set; }
            public object __invalid_name__737892 { get; set; }
            public object __invalid_name__738337 { get; set; }
            public object __invalid_name__738659 { get; set; }
            public object __invalid_name__738660 { get; set; }
            public string __invalid_name__738661 { get; set; }
            public string __invalid_name__738669 { get; set; }
            public object __invalid_name__738689 { get; set; }
            public object __invalid_name__738712 { get; set; }
            public string __invalid_name__738728 { get; set; }
            public object __invalid_name__738902 { get; set; }
            public string __invalid_name__738991 { get; set; }
            public object __invalid_name__739014 { get; set; }
            public object __invalid_name__739115 { get; set; }
            public object __invalid_name__739143 { get; set; }
            public object __invalid_name__739193 { get; set; }
            public string __invalid_name__739247 { get; set; }
            public string __invalid_name__740409 { get; set; }
            public object __invalid_name__740432 { get; set; }
            public object __invalid_name__740676 { get; set; }
            public object __invalid_name__740751 { get; set; }
            public object __invalid_name__740802 { get; set; }
            public string __invalid_name__741026 { get; set; }
            public object __invalid_name__741045 { get; set; }
            public object __invalid_name__741066 { get; set; }
            public string __invalid_name__741094 { get; set; }
            public object __invalid_name__741138 { get; set; }
            public object __invalid_name__741152 { get; set; }
            public object __invalid_name__741171 { get; set; }
            public object __invalid_name__741203 { get; set; }
            public string __invalid_name__741232 { get; set; }
            public object __invalid_name__741574 { get; set; }
            public object __invalid_name__742191 { get; set; }
            public object __invalid_name__742291 { get; set; }
            public string __invalid_name__742566 { get; set; }
            public object __invalid_name__742586 { get; set; }
            public object __invalid_name__742633 { get; set; }
            public string __invalid_name__742712 { get; set; }
            public object __invalid_name__742714 { get; set; }
            public object __invalid_name__742723 { get; set; }
            public object __invalid_name__742784 { get; set; }
            public object __invalid_name__742825 { get; set; }
            public object __invalid_name__742969 { get; set; }
            public object __invalid_name__742970 { get; set; }
            public object __invalid_name__742985 { get; set; }
            public string __invalid_name__743057 { get; set; }
            public object __invalid_name__743079 { get; set; }
            public object __invalid_name__743120 { get; set; }
            public object __invalid_name__743138 { get; set; }
            public object __invalid_name__743178 { get; set; }
            public object __invalid_name__743219 { get; set; }
            public object __invalid_name__743341 { get; set; }
            public object __invalid_name__743344 { get; set; }
            public object __invalid_name__743352 { get; set; }
            public object __invalid_name__743357 { get; set; }
            public object __invalid_name__743703 { get; set; }
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
            public int finalPlacement { get; set; }
            public int defaultSkill { get; set; }
            public int? skill { get; set; }
            public int skillOrder { get; set; }
            public bool unverified { get; set; }
            public object placement { get; set; }
            public List<object> expand { get; set; }
            public PlayerIds playerIds { get; set; }
            public int initialSeedNum { get; set; }
            public Prefixes prefixes { get; set; }
        }

        public class Player
        {
            public int id { get; set; }
            public string gamerTag { get; set; }
            public string prefix { get; set; }
            public string twitterHandle { get; set; }
            public string twitchStream { get; set; }
            public object streamMeStream { get; set; }
            public object redditUsername { get; set; }
            public object youtube { get; set; }
            public string smashboardsLink { get; set; }
            public int? smashboardsUserId { get; set; }
            public object ssbwikiLink { get; set; }
            public string playerType { get; set; }
            public int? rank { get; set; }
            public string color { get; set; }
            public string nameDisplay { get; set; }
            public object slug { get; set; }
            public string state { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public int? gamerTagChangedAt { get; set; }
            public List<object> images { get; set; }
            public string entrantId { get; set; }
            public List<object> rankings { get; set; }
            public string permissionType { get; set; }
        }

        public class RankingSery
        {
            public int id { get; set; }
            public int videogameId { get; set; }
            public int? sourceId { get; set; }
            public bool published { get; set; }
            public int status { get; set; }
            public int locationType { get; set; }
            public string locationName { get; set; }
            public int? locationRadius { get; set; }
            public string radiusUnit { get; set; }
            public int? locationId { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public int createdAt { get; set; }
            public int updatedAt { get; set; }
            public int? createdBy { get; set; }
            public List<object> images { get; set; }
            public string permissionType { get; set; }
        }

        public class RankingIteration
        {
            public int id { get; set; }
            public int seriesId { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
            public bool published { get; set; }
            public int status { get; set; }
            public bool active { get; set; }
            public string description { get; set; }
            public int publishedAt { get; set; }
            public int? startAt { get; set; }
            public int? endAt { get; set; }
            public int createdAt { get; set; }
            public int updatedAt { get; set; }
            public int? submittedAt { get; set; }
            public int createdBy { get; set; }
            public List<object> images { get; set; }
            public string permissionType { get; set; }
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
            public bool? tiebreaks { get; set; }
            public object bestOf { get; set; }
            public int setsOnDeck { get; set; }
            public int rematchSeconds { get; set; }
            public bool finalized { get; set; }
            public int? winnersTargetPhaseId { get; set; }
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
            public Tournament tournament { get; set; }
            public List<Entrant> entrants { get; set; }
            public List<Player> player { get; set; }
            public List<RankingSery> rankingSeries { get; set; }
            public List<RankingIteration> rankingIteration { get; set; }
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