

namespace CRUDApi.Model
{
    public class Response<T>
    {
        public Response()
        {
            IsSuccess = true;
            Message = "";
        }
       // [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
       // [JsonProperty("message")]
        public string Message { get; set; }
      //  [JsonProperty("data")]
        public T Data { get; set; }
    }
}
