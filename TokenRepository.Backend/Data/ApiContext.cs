using System.Text.Json.Serialization;

namespace TokenRepository.Backend.Data
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
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReturnStatus Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
