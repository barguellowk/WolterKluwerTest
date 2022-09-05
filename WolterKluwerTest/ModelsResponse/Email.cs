namespace WolterKluwerTest.ModelsResponse
{
    public class Email
    {
        public string emailId { get; set; }
        public string identityId { get; set; }
        public string email { get; set; }
        public bool principal { get; set; }
        public string state { get; set; }
        public List<string> extraData { get; set; }
    }
}
