using System;
using Xunit;

namespace RingCentral.Tests
{
    public class TokenRevokeTest
    {
        [Fact]
        public async void RevokeToken()
        {
            var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );
            Assert.NotNull(rc.token);
            await rc.Revoke();
            Assert.Null(rc.token);
        }
    }
}