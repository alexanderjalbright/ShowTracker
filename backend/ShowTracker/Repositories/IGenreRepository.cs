using ShowTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAll();
    }
}
