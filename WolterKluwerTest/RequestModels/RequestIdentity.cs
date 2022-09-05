namespace WolterKluwerTest.RequestModels
{
    public class RequestIdentity : RequestToken
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
