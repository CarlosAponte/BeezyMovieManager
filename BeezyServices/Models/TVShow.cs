using System;
using System.Collections.Generic;
using System.Text;

namespace BeezyServices.Models
{
    public class TVShow : ITVShow
    {
        public string Title { get; set; }
        public int NumberOfSeasons { get; set; }
        public int NumberOfEpisodes { get; set; }

        public List<ITVShow> GetRecomended()
        {



            return new List<ITVShow>()
            {
                new TVShow()
                {
                    Title = "Friends",
                    NumberOfEpisodes = 1000,
                    NumberOfSeasons = 10                    
                },
                new TVShow()
                {
                    Title = "How I met your mother",
                    NumberOfEpisodes = 900,
                    NumberOfSeasons = 9
                }
            };
        }
    }
}
