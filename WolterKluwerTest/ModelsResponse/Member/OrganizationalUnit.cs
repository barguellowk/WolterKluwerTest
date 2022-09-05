namespace WolterKluwerTest.ModelsResponse.Member
{
    public class OrganizationalUnit
    {
        public string organizationalUnitId { get; set; }
        public string kind { get; set; }
        public bool complexPassword { get; set; }
        public bool passwordCaducity { get; set; }
        public object passwordCaducityCounter { get; set; }
        public object passwordCaducityKind { get; set; }
        public bool allowGoogle { get; set; }
        public bool allowFacebook { get; set; }
        public bool allowWindows { get; set; }
        public bool allowTwitter { get; set; }
        public object parentId { get; set; }
        public bool isServiceProvider { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public object address { get; set; }
        public object postalCode { get; set; }
        public object city { get; set; }
        public object region { get; set; }
        public string country { get; set; }
        public List<string> extraData { get; set; }
    }
}
