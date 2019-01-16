using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class OwnerInfo : Serializable
    {
        // Internal identifier of an account
        public string accountId;
        // Internal identifier of an extension
        public string extensionId;
    }
}