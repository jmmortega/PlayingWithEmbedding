using System;
using Newtonsoft.Json;

namespace PlayingWithEmbedding.Core
{
    public class ResultJikan
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("image_url")]
        public string ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;   
        }

        [JsonProperty("score")]
        public double Score
        {
            get;
            set;    
        }

        [JsonProperty("episodes")]
        public int Episodes
        {
            get;
            set;
        }

        [JsonProperty("members")]
        public int Members
        {
            get;
            set;
        }
    }
}
