using System;
using System.Collections.Generic;

namespace BeezyServices.Interfaces
{
    public interface IMovie
    {
        string Title { get; set; }

        string Overview { get; set; }

        string Genre { get; set; }

        string Language { get; set; }

        DateTime FirstAirDate { get; set; }

        string WebSite { get; set; }

        List<string> Keywords{ get; set; }

 


    }
}
