using System.Collections.Generic;

namespace BeezyServices.Models
{
    public interface ITVShow
    {
        int NumberOfEpisodes { get; set; }
        int NumberOfSeasons { get; set; }
        string Title { get; set; }

        List<ITVShow> GetRecomended();
    }
}