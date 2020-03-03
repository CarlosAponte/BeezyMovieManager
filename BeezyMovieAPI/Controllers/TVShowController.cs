using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeezyServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BeezyMovieAPI.Controllers
{
    [Route("api/[controller]/GetRecomendations")]
    [ApiController]
    public class TVShowController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ITVShow _tvSHow;

        public TVShowController(IConfiguration config, ITVShow tvShow)
        {
            _config = config;
            _tvSHow = tvShow;
        }

        [HttpGet]
        public List<ITVShow> GetRecomendedTvShows()
        {
            var apiKey = _config.GetValue<string>("ApiKey");
            return _tvSHow.GetRecomended();
        }
    }
}