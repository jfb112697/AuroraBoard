using System.Collections.Generic;
namespace S3 { 
public class smashgg
{
        public class Links
        {
            public string facebook { get; set; }
        }

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

        public class Publishing
        {
            public bool publish { get; set; }
            public bool registration { get; set; }
            public bool attendees { get; set; }
            public List<object> seeding { get; set; }
            public bool bracket { get; set; }
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

        public class TaskEvents
        {
            public bool __invalid_name__32070 { get; set; }
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
            public object processingBase { get; set; }
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
            public Links links { get; set; }
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
            public string contactEmail { get; set; }
            public string contactTwitter { get; set; }
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
            public bool hasTaskEvents { get; set; }
            public TaskEvents taskEvents { get; set; }
            public List<string> slugs { get; set; }
            public string permissionType { get; set; }
            public bool supportsPayPal { get; set; }
        }

        public class PlayerIds
        {
            public int __invalid_name__730320 { get; set; }
            public int? __invalid_name__735186 { get; set; }
            public int? __invalid_name__738378 { get; set; }
            public int? __invalid_name__751169 { get; set; }
            public int? __invalid_name__752689 { get; set; }
            public int? __invalid_name__753770 { get; set; }
            public int? __invalid_name__753806 { get; set; }
            public int? __invalid_name__754760 { get; set; }
            public int? __invalid_name__755536 { get; set; }
            public int? __invalid_name__755678 { get; set; }
            public int? __invalid_name__755811 { get; set; }
            public int? __invalid_name__756089 { get; set; }
            public int? __invalid_name__757228 { get; set; }
            public int? __invalid_name__757633 { get; set; }
            public int? __invalid_name__757634 { get; set; }
            public int? __invalid_name__757760 { get; set; }
            public int? __invalid_name__757785 { get; set; }
            public int? __invalid_name__757833 { get; set; }
            public int? __invalid_name__757959 { get; set; }
            public int? __invalid_name__758384 { get; set; }
            public int? __invalid_name__758444 { get; set; }
            public int? __invalid_name__758451 { get; set; }
            public int? __invalid_name__758456 { get; set; }
            public int? __invalid_name__758470 { get; set; }
            public int? __invalid_name__758496 { get; set; }
            public int? __invalid_name__758525 { get; set; }
            public int? __invalid_name__758540 { get; set; }
            public int? __invalid_name__758721 { get; set; }
            public int? __invalid_name__758722 { get; set; }
            public int? __invalid_name__758772 { get; set; }
            public int? __invalid_name__758920 { get; set; }
            public int? __invalid_name__758979 { get; set; }
            public int? __invalid_name__759086 { get; set; }
            public int? __invalid_name__759156 { get; set; }
            public int? __invalid_name__759319 { get; set; }
            public int? __invalid_name__759588 { get; set; }
        }

        public class Prefixes
        {
            public string __invalid_name__730320 { get; set; }
            public string __invalid_name__735186 { get; set; }
            public string __invalid_name__738378 { get; set; }
            public object __invalid_name__751169 { get; set; }
            public object __invalid_name__752689 { get; set; }
            public object __invalid_name__753770 { get; set; }
            public string __invalid_name__753806 { get; set; }
            public object __invalid_name__754760 { get; set; }
            public string __invalid_name__755536 { get; set; }
            public string __invalid_name__755678 { get; set; }
            public string __invalid_name__755811 { get; set; }
            public object __invalid_name__756089 { get; set; }
            public object __invalid_name__757228 { get; set; }
            public string __invalid_name__757633 { get; set; }
            public object __invalid_name__757634 { get; set; }
            public object __invalid_name__757760 { get; set; }
            public string __invalid_name__757785 { get; set; }
            public object __invalid_name__757833 { get; set; }
            public object __invalid_name__757959 { get; set; }
            public object __invalid_name__758384 { get; set; }
            public object __invalid_name__758444 { get; set; }
            public object __invalid_name__758451 { get; set; }
            public object __invalid_name__758456 { get; set; }
            public object __invalid_name__758470 { get; set; }
            public object __invalid_name__758496 { get; set; }
            public object __invalid_name__758525 { get; set; }
            public string __invalid_name__758540 { get; set; }
            public string __invalid_name__758721 { get; set; }
            public object __invalid_name__758722 { get; set; }
            public object __invalid_name__758772 { get; set; }
            public object __invalid_name__758920 { get; set; }
            public object __invalid_name__758979 { get; set; }
            public object __invalid_name__759086 { get; set; }
            public object __invalid_name__759156 { get; set; }
            public object __invalid_name__759319 { get; set; }
            public object __invalid_name__759588 { get; set; }
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
            public object finalPlacement { get; set; }
            public int defaultSkill { get; set; }
            public object skill { get; set; }
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
            public double? rank { get; set; }
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
            public int? status { get; set; }
            public bool active { get; set; }
            public string description { get; set; }
            public int publishedAt { get; set; }
            public int? startAt { get; set; }
            public int? endAt { get; set; }
            public int createdAt { get; set; }
            public int updatedAt { get; set; }
            public int? submittedAt { get; set; }
            public int? createdBy { get; set; }
            public List<object> images { get; set; }
            public string permissionType { get; set; }
        }

        public class Entities
        {
            public Tournament tournament { get; set; }
            public List<Entrant> entrants { get; set; }
            public List<Player> player { get; set; }
            public List<RankingSery> rankingSeries { get; set; }
            public List<RankingIteration> rankingIteration { get; set; }
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