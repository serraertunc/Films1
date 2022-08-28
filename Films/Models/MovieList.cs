﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Models
{
    public class MovieList
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<MovieMovieList> MoviesMovieLists { get; set; }

    }
}
