using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Films.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        
        public bool InListBool { get; set; }
        public string SearchStringTitle { get; set; }
        public string SearchStringDirector { get; set; }
    }
}
