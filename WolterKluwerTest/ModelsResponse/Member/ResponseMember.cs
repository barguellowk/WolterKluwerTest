namespace WolterKluwerTest.ModelsResponse.Member
{
    public class ResponseMember
    {
        public object Identity { get; set; }
        public object Invitation { get; set; }
        public OrganizationalUnit OrganizationalUnit { get; set; }
        public List<object> Roles { get; set; }
        public object invitationId { get; set; }
        public string IdentityId { get; set; }
        public string OrganizationalUnitId { get; set; }
        public string MemberId { get; set; }
        public string ProfileType { get; set; }
        public List<object> Rights { get; set; }
        public List<object> ExtraData { get; set; }
        public string State { get; set; }
        public string Error { get; set; }
    }
}
