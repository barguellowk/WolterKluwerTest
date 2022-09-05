using Newtonsoft.Json;
using System.ComponentModel;

namespace WolterKluwerTest.RequestModels
{
    public class RequestToken
    {
        [JsonProperty("grant_type")]
        [DefaultValue("client_credentials")]
        public string GrantType { get; set; } = string.Empty;

        [JsonProperty("client_id")]
        [DefaultValue("becquer.arguello")]
        public string ClientId { get; set; } = string.Empty;

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; } = string.Empty;

        [JsonProperty("scope")]
        [DefaultValue("WK.GraphAPI.Private")]
        public string Scope { get; set; } = string.Empty;
    }
}
