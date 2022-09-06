using Newtonsoft.Json;
using System.ComponentModel;

namespace WolterKluwerTest.RequestModels
{
    public class RequestToken
    {
        [JsonProperty("grant_type")]
        public string GrantType { get; } = "client_credentials";

        [JsonProperty("client_id")]
        public string ClientId { get; } = "becquer.arguello";

        [JsonProperty("client_secret")]
        public string ClientSecret { get; } = "123456";

        [JsonProperty("scope")]
        public string Scope { get; } = "WK.GraphAPI.Private";
    }
}
