using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Enums;

namespace api.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public int MovieId{ get; set; }
        public List<Movie> Movies{ get; set; } = new List<Movie>();
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public JobEnum Role { get; set;}
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime LastUpdatedOn { get; set;} = DateTime.Now;
    }
}