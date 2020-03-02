using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeezyServices.Interfaces;

namespace BeezyServices.Models
{
    public class Movie : IMovie
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public DateTime FirstAirDate { get; set; }
        public string WebSite { get; set; }
        public List<string> Keywords {get; set; }

        public IMovie GetMovie(IMovie movie)
        {
            return new Movie { Genre = "Horror", Title = "The nun", FirstAirDate = DateTime.Now };
        }
    }
}
