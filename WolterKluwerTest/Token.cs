using Newtonsoft.Json;

namespace WolterKluwerTest
{
    public class Token
    {
        [JsonProperty("id_token")]
        public string IdToken { get; set; } = string.Empty;
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; } = string.Empty;
        [JsonProperty("access_token")]
        public string AccessToken { get; set; } = string.Empty;
        public bool HasError { get; set; } = false;
        public string Error { get; set; } = string.Empty;
    }
}
