namespace TokenRepository.NetworkRequest.Models
{
    public enum ApiStatus
    {
        Success, Error, Warning
    }
    public class ApiContext
    {
        public ApiContext() { }
        public ApiContext(ApiStatus status, string message, object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
        public ApiStatus Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
