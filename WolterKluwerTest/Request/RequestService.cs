using System.Net.Http.Headers;

namespace WolterKluwerTest.Request
{
    public static class RequestService
    {
        public static HttpResponseMessage DoPostRequest(string uri, Dictionary<string, string> parameters)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsync(uri, new FormUrlEncodedContent(parameters)).Result;
            return response;
        }

        public static HttpResponseMessage DoPostRequest(string uri, string token, Dictionary<string, string> parameters)
        {
            var client = CreateClient(token);
            HttpResponseMessage response = client.PostAsync(uri, new FormUrlEncodedContent(parameters)).Result;
            return response;
        }

        public static HttpResponseMessage DoPostRequest(string uri, string token, object requestParams)
        {
            var client = CreateClient(token);
            var response = client.PostAsJsonAsync(uri, requestParams).Result;
            return response;
        }

        public static HttpResponseMessage DoDeleteRequest(string uri, string token)
        {
            var client = CreateClient(token);
            var response = client.DeleteAsync(uri).Result;
            return response;
        }

        public static HttpClient CreateClient(string token) 
        {
            HttpClient client = new();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
