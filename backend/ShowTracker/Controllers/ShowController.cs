using Microsoft.AspNetCore.Mvc;
using ShowTracker.Models;
using ShowTracker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        IShowRepository repo; 
        public ShowController(IShowRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("{id}")]
        public ActionResult<Show> Get(int id)
        {
            var show = repo.GetById(id);

            return show;
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Show newShow)
        {
            repo.Create(newShow);

            return true;
        }

        [HttpPost("{id}")]
        public ActionResult<bool> Post(int id, [FromBody] Show show)
        {
            repo.Update(show);

            return true;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var show = repo.GetById(id);
            repo.Delete(show);

            return true;
        }
    }
}
