using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeezyServices.Interfaces
{
    public interface ITvShow
    {
        int Title { get; set; }

        string Overview { get; set; }

        string Genre { get; set; }

        string Language { get; set; }

        DateTime FirstAirDate { get; set; }

        string WebSite { get; set; }

        List<string> Keywords { get; set; }

        int NumberOfSeasons { get; set; }

        int NumberOfEpisodes { get; set; }

        bool IsItConcluded { get; set; }
       

    }
}
