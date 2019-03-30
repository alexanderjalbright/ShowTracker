using ShowTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        ShowContext db;
        public GenreRepository(ShowContext db)
        {
            this.db = db;  
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres.ToList();
        }
    }
}
