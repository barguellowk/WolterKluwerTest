using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ModelsResponse
{
    public class ResponseCreateIdentity
    {
        public string state { get; set; }
        public object passwordStrength { get; set; }
        public DateTime lastPasswordChangeDate { get; set; }
        public object isSubscribedToNewsletter { get; set; }
        public bool isUnlisted { get; set; }
        public object unlistedType { get; set; }
        public bool authenticationOnly { get; set; }
        public bool changePasswordNextLogon { get; set; }
        public List<string> members { get; set; }
        public object externalIdentities { get; set; }
        public object creationData { get; set; }
        public List<Email> emails { get; set; }
        public string identityId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public List<object> extraData { get; set; }
        public string Error { get; set; }
    }
}
