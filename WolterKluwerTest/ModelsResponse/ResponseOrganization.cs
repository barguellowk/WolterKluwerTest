using Newtonsoft.Json;

namespace WolterKluwerTest.ModelsResponse
{
    public class ResponseOrganization
    {
        [JsonProperty("members")]
        public object Members { get; set; }

        [JsonProperty("licensedApplications")]
        public object LicensedApplications { get; set; }

        [JsonProperty("grantedApplications")]
        public object GrantedApplications { get; set; }

        [JsonProperty("legalEntities")]
        public object LegalEntities { get; set; }

        [JsonProperty("organizationalUnitId")]
        public string OrganizationalUnitId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("complexPassword")]
        public bool ComplexPassword { get; set; }

        [JsonProperty("members")]
        public bool passwordCaducity { get; set; }

        [JsonProperty("passwordCaducityCounter")]
        public object PasswordCaducityCounter { get; set; }

        [JsonProperty("passwordCaducityKind")]
        public object PasswordCaducityKind { get; set; }

        [JsonProperty("allowGoogle")]
        public bool AllowGoogle { get; set; }

        [JsonProperty("allowFacebook")]
        public bool AllowFacebook { get; set; }

        [JsonProperty("allowWindows")]
        public bool AllowWindows { get; set; }

        [JsonProperty("allowTwitter")]
        public bool AllowTwitter { get; set; }

        [JsonProperty("parentId")]
        public object ParentId { get; set; }

        [JsonProperty("isServiceProvider")]
        public bool IsServiceProvider { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("postalCode")]
        public object PostalCode { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("extraData")]
        public List<string> ExtraData { get; set; }
        public string Error { get; set; }
    }
}
