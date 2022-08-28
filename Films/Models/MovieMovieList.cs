using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Models
{
    public class MovieMovieList
    {
        public int MovieMovieListID { get; set; }
        public int MovieID { get; set; }
        public int MovieListID { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual MovieList MovieLists { get; set; }

        public Guid UserId { get; set; }

    }

}
