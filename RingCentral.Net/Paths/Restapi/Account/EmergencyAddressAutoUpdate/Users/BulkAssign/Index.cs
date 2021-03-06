using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Users.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Users.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Enable Automatic Location Updates for Users
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign
        /// </summary>
        public async Task<string> Post(
            RingCentral.BulkAssignAutomaticaLocationUpdatesUsers bulkAssignAutomaticaLocationUpdatesUsers)
        {
            return await rc.Post<string>(this.Path(), bulkAssignAutomaticaLocationUpdatesUsers);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign.Index(this);
        }
    }
}