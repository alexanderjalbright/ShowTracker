using ShowTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Repositories
{
    public interface IShowRepository
    {
        void Create(Show show);

        Show GetById(int id);

        void Update(Show show);

        void Delete(Show show);
    }
}
