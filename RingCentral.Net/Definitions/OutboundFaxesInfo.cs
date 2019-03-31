namespace RingCentral
{
    public class OutboundFaxesInfo
    {
        /// <summary>
        /// Email notification flag
        /// </summary>
        public bool? notifyByEmail;

        /// <summary>
        /// SMS notification flag
        /// </summary>
        public bool? notifyBySms;

        /// <summary>
        /// List of recipient email addresses for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedEmailAddresses;

        /// <summary>
        /// List of recipient phone numbers for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        public string[] advancedSmsEmailAddresses;
    }
}