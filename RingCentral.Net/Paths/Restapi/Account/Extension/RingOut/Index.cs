using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.RingOut
{
    public partial class Index
    {
        public RestClient rc;
        public string ringoutId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string ringoutId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ringoutId = ringoutId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ringoutId != null)
            {
                return $"{parent.Path()}/ring-out/{ringoutId}";
            }

            return $"{parent.Path()}/ring-out";
        }

        /// <summary>
        /// Operation: Make RingOut Call
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Post(RingCentral.MakeRingOutRequest makeRingOutRequest)
        {
            return await rc.Post<RingCentral.GetRingOutStatusResponse>(this.Path(false), makeRingOutRequest);
        }

        /// <summary>
        /// Operation: Get RingOut Call Status
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// </summary>
        public async Task<RingCentral.GetRingOutStatusResponse> Get()
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Get<RingCentral.GetRingOutStatusResponse>(this.Path());
        }

        /// <summary>
        /// Operation: Cancel RingOut Call
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.ringoutId == null)
            {
                throw new System.ArgumentNullException("ringoutId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.RingOut.Index RingOut(string ringoutId = null)
        {
            return new Restapi.Account.Extension.RingOut.Index(this, ringoutId);
        }
    }
}