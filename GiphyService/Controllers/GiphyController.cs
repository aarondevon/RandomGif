using Giphy.Libs.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyService.Controllers
{
    [ApiController]
    [Route("v1/giphy/random/{searchCritera}")]
    public class GiphyController : Controller
    {
        private readonly IGiphyService _giphyService;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyService = giphyService;
        }

        [HttpGet]
        public async Task<IActionResult> getRandomGif(string searchCritera)
        {
            var result = await _giphyService.GetRandomGifBasedOnSearchCritera(searchCritera);

            return Ok(result);
        }
    }
}
