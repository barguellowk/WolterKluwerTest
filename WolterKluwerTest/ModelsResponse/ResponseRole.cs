namespace WolterKluwerTest.ModelsResponse
{
    public class ResponseRole
    {
        public List<object> extraData { get; set; }
        public List<object> consumes { get; set; }
        public List<object> relatedConsumptions { get; set; }
        public string roleId { get; set; }
        public string licensedApplicationId { get; set; }
        public object grantedApplicationId { get; set; }
        public string memberId { get; set; }
        public string Error { get; set; }
    }
}
