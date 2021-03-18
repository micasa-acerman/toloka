using Newtonsoft.Json;
using System.Collections.Generic;

namespace TolokaManager.Models
{
    public class Answer
    {
        [JsonProperty]
        public string id;
        [JsonProperty]
        public int pool_id;
        [JsonProperty]
        public string status;
        [JsonProperty]
        public string user_id;
        public List<string> left;
        public List<string> right;
    }
}
