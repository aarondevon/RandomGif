using Giphy.Libs.Giphy;
using Giphy.Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Giphy.Libs.Services;

namespace Giphy.Libs.Services
{
    public class GiphyService : IGiphyService
    {
        private readonly IGetRandomGif _getRandomGif;

        public GiphyService(IGetRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }

        public async Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera)
        {
            return await _getRandomGif.ReturnRandomGifBasedOnTag(searchCritera);
        }
    }
}
