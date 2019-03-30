using ShowTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Repositories
{
    public class ShowRepository : IShowRepository
    {
        ShowContext db;
        public ShowRepository(ShowContext db)
        {
            this.db = db;
        }

        public void Create(Show show)
        {
            db.Add(show);
            db.SaveChanges();
        }

        public Show GetById(int showId)
        {
            return db.Shows.Single(show => show.ShowId == showId);
        }

        public void Update(Show show)
        {
            db.Update(show);
            db.SaveChanges();
        }

        public void Delete(Show show) 
        {
            db.Remove(show);
            db.SaveChanges();
        }
    }
}
