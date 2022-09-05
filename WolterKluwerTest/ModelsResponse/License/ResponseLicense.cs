namespace WolterKluwerTest.ModelsResponse.License
{
    public class ResponseLicense
    {
        public Application Application { get; set; }
        public List<string> extraData { get; set; }
        public string licensedApplicationId { get;set; }
        public string applicationId { get;set; }
        public object licenseId { get;set; }
        public string organizationalUnitId { get;set; }
        public string Error { get;set; }
    }
}
