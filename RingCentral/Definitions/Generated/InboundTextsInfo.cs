using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class InboundTextsInfo : Serializable
    {
        // Email notification flag
        public bool? notifyByEmail;
        // SMS notification flag
        public bool? notifyBySms;
        // List of recipient email addresses for inbound text message notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedEmailAddresses;
        // List of recipient phone numbers for inbound text message notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] advancedSmsEmailAddresses;
    }
}