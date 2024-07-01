using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Enums;


namespace api.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int MovieId{ get; set; }
        public Movie? Movie { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime LastUpdatedOn { get; set;} = DateTime.Now;
        public MovieScoreEnum MovieScoreEnum;
    }
}