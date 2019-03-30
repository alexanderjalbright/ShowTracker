using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
        public virtual IEnumerable<Show> Shows { get; set; }
    }
}
