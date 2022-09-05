namespace WolterKluwerTest.RequestModels
{
    public class Requestorganization
    {
        public bool AllowTwitter { get; set; }
        public bool AllowWindows { get; set; }
        public bool AllowFacebook { get; set; }
        public object PasswordCaducityKind { get; set; }
        public object PasswordCaducityCounter { get; set; }
        public bool PasswordCaducity { get; set; }
        public string Country { get; set; }
        public object Region { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Kind { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
    }
}
