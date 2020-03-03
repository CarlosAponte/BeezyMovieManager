using System;
using System.Collections.Generic;
using System.Text;

namespace BeezyServices.Models
{
    public class Movie : IMovie
    {
        public string Title { get; set; }
        public string Overview { get; set; }
    }
}
