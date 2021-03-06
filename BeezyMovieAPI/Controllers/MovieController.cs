﻿using System;
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
    public class MovieController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IMovie _movie;

        public MovieController(IConfiguration config, IMovie movie)
        {
            _config = config;
            _movie = movie;
        }

        [HttpGet]
        public IMovie GetMovies()
        {
            var apiKey = _config.GetValue<string>("ApiKey");
            _movie.Title = "The NUN";
            _movie.Overview = "Horror movie with a creepy nun";
            return _movie;
        }
    }
}