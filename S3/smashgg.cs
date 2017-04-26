using System;
using System.Collections.Generic;

namespace S3
{
    static class smashgg
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

        public class CountryId
        {
            public bool visible { get; set; }
            public bool required { get; set; }
        }

        public class StateId
        {
            public bool visible { get; set; }
            public bool required { get; set; }
        }

        public class AttendeeFieldConfig
        {
            public NameFirst nameFirst { get; set; }
            public NameLast nameLast { get; set; }
            public PhoneNumber phoneNumber { get; set; }
            public CountryId countryId { get; set; }
            public StateId stateId { get; set; }
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
            public string hashtag { get; set; }
            public object showCity { get; set; }
            public int attendeeLocationInfo { get; set; }
            public int attendeeContactInfo { get; set; }
            public AttendeeFieldConfig attendeeFieldConfig { get; set; }
            public object attendeeRequirements { get; set; }
            public bool notifyAdmins { get; set; }
            public bool publicAttendees { get; set; }
            public bool hideAdmins { get; set; }
            public string videoUrl { get; set; }
            public string details { get; set; }
            public object registrationMarkdown { get; set; }
            public object gettingThere { get; set; }
            public string prizes { get; set; }
            public string rules { get; set; }
            public string contactInfo { get; set; }
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
            public string contactPhone { get; set; }
            public string currency { get; set; }
            public string onsitePaymentMode { get; set; }
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

        public class Participant
        {
            public int id { get; set; }
            public int playerId { get; set; }
            public int tournamentId { get; set; }
            public string gamerTag { get; set; }
            public string prefix { get; set; }
            public string cityState { get; set; }
            public object venueType { get; set; }
            public bool claimed { get; set; }
            public List<object> paid { get; set; }
        }

        public class Entities
        {
            public Tournament tournament { get; set; }
            public List<Participant> participants { get; set; }
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
