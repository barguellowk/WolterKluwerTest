using Newtonsoft.Json;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.Request
{
    public static class TokenService
    {
        public static void GetToken(RequestToken requestParams)
        {
            var uri = UriConts.uriBaseLoginDev + "auth/core/connect/token";
            var objectResponse = new Token();
            var parameters = new Dictionary<string, string>();
            parameters.Add("grant_type", requestParams.GrantType);
            parameters.Add("client_id", requestParams.ClientId);
            parameters.Add("client_secret", requestParams.ClientSecret);
            parameters.Add("scope", requestParams.Scope);

            HttpResponseMessage response = RequestService.DoPostRequest(uri, parameters);
            var value = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                objectResponse = JsonConvert.DeserializeObject<Token>(value);
            }
            else
            {
                objectResponse.Error = value;
                objectResponse.HasError = true;
            }

            Token = objectResponse;
        }

        public static Token? Token { get; set; }
    }
}
