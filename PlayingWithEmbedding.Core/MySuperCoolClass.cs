using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NSUtils;

namespace PlayingWithEmbedding.Core
{
    public class MySuperCoolClass
    {
        
        public void GetAnime(string query, Action<List<ResultJikan>> callback)
        {
            var jikanResults = new List<ResultJikan>();

            new HttpCalls().Get($"https://api.jikan.me/search/anime/{query}/1",
                                (obj) =>
                                {
                                    var rawJson = obj.ToResponseString();
                                    callback.Invoke(JsonConvert.DeserializeObject<List<ResultJikan>>(JObject.Parse(rawJson).SelectToken("result").ToString(), 
                                                                                 new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
                                }, null);
        }

        public async Task<List<ResultJikan>> GetAnimeAsync(string query)
        {
            var response = await new HttpCalls().GetAsync($"https://api.jikan.me/search/anime/{query}/1");
            var rawJson = response.ToResponseString();
            return JsonConvert.DeserializeObject<List<ResultJikan>>(JObject.Parse(rawJson).SelectToken("result").ToString());
        }

    }
}
