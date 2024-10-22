using Newtonsoft.Json;

namespace APITesting
{
    internal class APIResponse
    {
        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("apiResponse")]
        public int code { get; set; }
    }
}
