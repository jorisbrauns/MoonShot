namespace WebApi.RequestsEntities
{
    public class PagingCriteriaRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}