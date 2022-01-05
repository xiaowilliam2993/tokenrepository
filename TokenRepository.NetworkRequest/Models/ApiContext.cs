namespace TokenRepository.NetworkRequest.Models
{
    public enum ReturnStatus
    {
        Success, Error, Warning
    }
    public class ApiContext
    {
        public ApiContext() { }
        public ApiContext(ReturnStatus status, string message, object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
        public ReturnStatus Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
