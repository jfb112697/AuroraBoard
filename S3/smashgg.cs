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

        public class Seeding
        {
            public bool __invalid_name__130173 { get; set; }
            public bool __invalid_name__130174 { get; set; }
        }

        public class Bracket
        {
            public bool __invalid_name__130173 { get; set; }
            public bool __invalid_name__130174 { get; set; }
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
            public object stripeMode { get; set; }
            public object paypalMode { get; set; }
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
            public object hashtag { get; set; }
            public object showCity { get; set; }
            public int attendeeLocationInfo { get; set; }
            public int attendeeContactInfo { get; set; }
            public AttendeeFieldConfig attendeeFieldConfig { get; set; }
            public object attendeeRequirements { get; set; }
            public bool notifyAdmins { get; set; }
            public bool publicAttendees { get; set; }
            public bool hideAdmins { get; set; }
            public object videoUrl { get; set; }
            public object details { get; set; }
            public object registrationMarkdown { get; set; }
            public object gettingThere { get; set; }
            public string prizes { get; set; }
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
            public object stripePublishableKey { get; set; }
            public object paypalPayerId { get; set; }
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
            public int __invalid_name__759185 { get; set; }
            public int? __invalid_name__759628 { get; set; }
            public int? __invalid_name__759633 { get; set; }
            public int? __invalid_name__759636 { get; set; }
            public int? __invalid_name__759639 { get; set; }
            public int? __invalid_name__759640 { get; set; }
            public int? __invalid_name__759646 { get; set; }
            public int? __invalid_name__759652 { get; set; }
            public int? __invalid_name__759653 { get; set; }
            public int? __invalid_name__759654 { get; set; }
            public int? __invalid_name__759657 { get; set; }
            public int? __invalid_name__759660 { get; set; }
            public int? __invalid_name__759704 { get; set; }
            public int? __invalid_name__759707 { get; set; }
            public int? __invalid_name__759713 { get; set; }
            public int? __invalid_name__759717 { get; set; }
            public int? __invalid_name__759718 { get; set; }
            public int? __invalid_name__759727 { get; set; }
            public int? __invalid_name__759733 { get; set; }
            public int? __invalid_name__759737 { get; set; }
            public int? __invalid_name__759740 { get; set; }
            public int? __invalid_name__759744 { get; set; }
            public int? __invalid_name__759749 { get; set; }
            public int? __invalid_name__759752 { get; set; }
            public int? __invalid_name__759754 { get; set; }
            public int? __invalid_name__759756 { get; set; }
            public int? __invalid_name__759758 { get; set; }
            public int? __invalid_name__759762 { get; set; }
            public int? __invalid_name__759765 { get; set; }
            public int? __invalid_name__759768 { get; set; }
            public int? __invalid_name__759770 { get; set; }
            public int? __invalid_name__759772 { get; set; }
            public int? __invalid_name__759778 { get; set; }
            public int? __invalid_name__759781 { get; set; }
            public int? __invalid_name__759786 { get; set; }
            public int? __invalid_name__759788 { get; set; }
            public int? __invalid_name__759791 { get; set; }
            public int? __invalid_name__759797 { get; set; }
            public int? __invalid_name__759812 { get; set; }
            public int? __invalid_name__759815 { get; set; }
            public int? __invalid_name__759816 { get; set; }
            public int? __invalid_name__759825 { get; set; }
            public int? __invalid_name__759826 { get; set; }
            public int? __invalid_name__759828 { get; set; }
            public int? __invalid_name__759829 { get; set; }
            public int? __invalid_name__759830 { get; set; }
            public int? __invalid_name__759831 { get; set; }
            public int? __invalid_name__759833 { get; set; }
            public int? __invalid_name__759835 { get; set; }
            public int? __invalid_name__759836 { get; set; }
            public int? __invalid_name__759843 { get; set; }
            public int? __invalid_name__759852 { get; set; }
            public int? __invalid_name__759853 { get; set; }
            public int? __invalid_name__759810 { get; set; }
        }

        public class Prefixes
        {
            public string __invalid_name__759185 { get; set; }
            public object __invalid_name__759628 { get; set; }
            public string __invalid_name__759633 { get; set; }
            public object __invalid_name__759636 { get; set; }
            public object __invalid_name__759639 { get; set; }
            public string __invalid_name__759640 { get; set; }
            public object __invalid_name__759646 { get; set; }
            public object __invalid_name__759652 { get; set; }
            public object __invalid_name__759653 { get; set; }
            public object __invalid_name__759654 { get; set; }
            public object __invalid_name__759657 { get; set; }
            public object __invalid_name__759660 { get; set; }
            public object __invalid_name__759704 { get; set; }
            public object __invalid_name__759707 { get; set; }
            public object __invalid_name__759713 { get; set; }
            public object __invalid_name__759717 { get; set; }
            public string __invalid_name__759718 { get; set; }
            public object __invalid_name__759727 { get; set; }
            public object __invalid_name__759733 { get; set; }
            public object __invalid_name__759737 { get; set; }
            public object __invalid_name__759740 { get; set; }
            public object __invalid_name__759744 { get; set; }
            public string __invalid_name__759749 { get; set; }
            public object __invalid_name__759752 { get; set; }
            public object __invalid_name__759754 { get; set; }
            public string __invalid_name__759756 { get; set; }
            public object __invalid_name__759758 { get; set; }
            public object __invalid_name__759762 { get; set; }
            public object __invalid_name__759765 { get; set; }
            public object __invalid_name__759768 { get; set; }
            public object __invalid_name__759770 { get; set; }
            public string __invalid_name__759772 { get; set; }
            public object __invalid_name__759778 { get; set; }
            public object __invalid_name__759781 { get; set; }
            public object __invalid_name__759786 { get; set; }
            public object __invalid_name__759788 { get; set; }
            public object __invalid_name__759791 { get; set; }
            public string __invalid_name__759797 { get; set; }
            public object __invalid_name__759812 { get; set; }
            public object __invalid_name__759815 { get; set; }
            public object __invalid_name__759816 { get; set; }
            public object __invalid_name__759825 { get; set; }
            public string __invalid_name__759826 { get; set; }
            public object __invalid_name__759828 { get; set; }
            public object __invalid_name__759829 { get; set; }
            public object __invalid_name__759830 { get; set; }
            public object __invalid_name__759831 { get; set; }
            public object __invalid_name__759833 { get; set; }
            public object __invalid_name__759835 { get; set; }
            public object __invalid_name__759836 { get; set; }
            public int? __invalid_name__759843 { get; set; }
            public string __invalid_name__759852 { get; set; }
            public string __invalid_name__759853 { get; set; }
            public string __invalid_name__759810 { get; set; }
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
            public int locationId { get; set; }
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