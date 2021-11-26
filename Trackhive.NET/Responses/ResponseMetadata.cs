namespace Trackhive.NET.Responses
{
    public class ResponseMetadata
    {
        public int? CurrentPage { get; set; }
        public int? RecordsPerPage { get; set; }
        public int? TotalRecords { get; set; }
        public int Code { get; set; }
    }
}