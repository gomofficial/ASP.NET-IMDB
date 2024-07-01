using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<Comments> Comments { get; set; } = new List<Comments>();
        public List<Cast> Cast { get; set; } = new List<Cast>();
        public List<Score> Scores { get; set; } = new List<Score>;
    }
}