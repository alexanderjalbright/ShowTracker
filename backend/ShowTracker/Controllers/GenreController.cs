using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShowTracker.Models;
using ShowTracker.Repositories;

namespace ShowTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        IGenreRepository repo;
        public GenreController(IGenreRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Genre>> Get()
        {
            var genreList = repo.GetAll().ToArray();

            return genreList;

        }
    }
}