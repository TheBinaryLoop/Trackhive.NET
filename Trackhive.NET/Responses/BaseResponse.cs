namespace Trackhive.NET.Responses
{
    public class BaseResponse<T>
    {
        public ResponseMetadata Meta { get; set; }
        public T Data { get; set; }
    }
}