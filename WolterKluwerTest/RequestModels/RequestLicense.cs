using Newtonsoft.Json;
using System.ComponentModel;

namespace WolterKluwerTest.RequestModels
{
    public class RequestLicense
    {
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
    }
}
