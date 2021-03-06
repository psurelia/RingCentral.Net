using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking.PhoneNumbers
{
    public partial class Index
    {
        public RestClient rc;
        public string blockedNumberId;
        public Restapi.Account.Extension.CallerBlocking.Index parent;

        public Index(Restapi.Account.Extension.CallerBlocking.Index parent, string blockedNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.blockedNumberId = blockedNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && blockedNumberId != null)
            {
                return $"{parent.Path()}/phone-numbers/{blockedNumberId}";
            }

            return $"{parent.Path()}/phone-numbers";
        }

        /// <summary>
        /// Operation: Get Blocked/Allowed Phone Numbers
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumbersList> List(
            ListBlockedAllowedNumbersParameters queryParams = null)
        {
            return await rc.Get<RingCentral.BlockedAllowedPhoneNumbersList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Add Blocked/Allowed Number
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Post(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber)
        {
            return await rc.Post<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(false),
                addBlockedAllowedPhoneNumber);
        }

        /// <summary>
        /// Operation: Get Blocked/Allowed Number
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Get()
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Get<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Delete Blocked/Allowed Number
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Delete<string>(this.Path());
        }

        /// <summary>
        /// Operation: Update Blocked/Allowed Number
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}
        /// </summary>
        public async Task<RingCentral.BlockedAllowedPhoneNumberInfo> Put(
            RingCentral.AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber)
        {
            if (this.blockedNumberId == null)
            {
                throw new System.ArgumentNullException("blockedNumberId");
            }

            return await rc.Put<RingCentral.BlockedAllowedPhoneNumberInfo>(this.Path(), addBlockedAllowedPhoneNumber);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.CallerBlocking
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index PhoneNumbers(string blockedNumberId = null)
        {
            return new Restapi.Account.Extension.CallerBlocking.PhoneNumbers.Index(this, blockedNumberId);
        }
    }
}