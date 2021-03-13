using Giphy.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Giphy.Libs.Giphy
{
    public class GetRandomGif : IGetRandomGif
    {
        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "Iohv4JvwrJVDVOndT0Ayh6kOUB6W6FXC";

            using (var client = new HttpClient())
            {
                var url = new Uri($"https://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=25&offset=0&rating=g&lang=en");

                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}
