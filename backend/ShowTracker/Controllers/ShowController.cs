using Microsoft.AspNetCore.Mvc;
using ShowTracker.Models;
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
        [HttpGet]
        public ActionResult<IEnumerable<Show>> Get()
        {
            var showList = new List<Show>()
            { new Show(), new Show() };

            return showList;
        }
    }
}
