using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Chats.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        /// Operation: Create Note
        /// Http Post /restapi/v1.0/glip/chats/{chatId}/notes
        /// </summary>
        public async Task<RingCentral.GlipNoteInfo> Post(RingCentral.GlipNoteCreate glipNoteCreate)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate);
        }

        /// <summary>
        /// Operation: Get Chat Notes
        /// Http Get /restapi/v1.0/glip/chats/{chatId}/notes
        /// </summary>
        public async Task<RingCentral.GlipNotesInfo> Get(ListChatNotesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Notes.Index Notes()
        {
            return new Restapi.Glip.Chats.Notes.Index(this);
        }
    }
}