using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PermissionIdResource : Serializable
    {
        public string uri;
        public string id;
        // Site compatibility flag set for permission
        // Enum: Compatible, Incompatible, Independent
        public string siteCompatible;
    }
}