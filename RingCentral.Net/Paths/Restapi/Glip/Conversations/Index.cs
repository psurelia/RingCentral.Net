using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Conversations
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/conversations/{chatId}";
            }

            return $"{parent.Path()}/conversations";
        }

        /// <summary>
        /// Operation: Get Conversations
        /// Http Get /restapi/v1.0/glip/conversations
        /// </summary>
        public async Task<RingCentral.GlipConversationsList> List(ListGlipConversationsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipConversationsList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Create/Open Conversation
        /// Http Post /restapi/v1.0/glip/conversations
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Post(
            RingCentral.CreateGlipConversationRequest createGlipConversationRequest)
        {
            return await rc.Post<RingCentral.GlipConversationInfo>(this.Path(false), createGlipConversationRequest);
        }

        /// <summary>
        /// Operation: Get Conversation
        /// Http Get /restapi/v1.0/glip/conversations/{chatId}
        /// </summary>
        public async Task<RingCentral.GlipConversationInfo> Get()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipConversationInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Conversations.Index Conversations(string chatId = null)
        {
            return new Restapi.Glip.Conversations.Index(this, chatId);
        }
    }
}