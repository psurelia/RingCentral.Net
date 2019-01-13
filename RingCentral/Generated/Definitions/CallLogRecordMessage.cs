using Newtonsoft.Json;

namespace RingCentral
{
    public class CallLogRecordMessage : Serializable
    {
        // Internal identifier of a message
        public string id;
        // Type of a message
        public string type;
        // Link to a message resource
        public string uri;
    }
}