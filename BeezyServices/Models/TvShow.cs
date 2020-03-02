using BeezyServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeezyServices.Models
{
    public class TvShow : ITvShow
    {
        public int Title { get; set; }
        public string Overview { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public DateTime FirstAirDate { get; set; }
        public string WebSite { get; set; }
        public List<string> Keywords { get; set; }
        public int NumberOfSeasons { get; set; }
        public int NumberOfEpisodes { get; set; }
        public bool IsItConcluded { get; set; }
    }
}
