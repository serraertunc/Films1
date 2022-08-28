using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Films.Models
{
    public class Movies
    {
        
        public int Id { get; set; }
        public string? Title { get; set; }
        public Boolean InMovieList { get; set; }

        public string? Genre { get; set; }

        public string? Director { get; set; }
        public double Score { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<MovieMovieList> MoviesMovieLists{ get; set; }
}

   
}
