using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int MovieId{ get; set; }
        public Movie? Movie{ get; set; }
        public int UserId{ get; set; }
        public User? User{ get; set; }
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime LastUpdatedOn { get; set;} = DateTime.Now;

    }
}