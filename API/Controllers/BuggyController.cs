using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;

        public BuggyController(DataContext context)
        {
            context = _context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetResult() {
            return "secret result";
        }
        
        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound() {
            var thing = 2;
            
            if (thing == 2) return NotFound();
            
            return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError() {
            var thing = _context.Users.Find(-1);
            
            var thingReturn = thing.ToString();
            
            return thingReturn;
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest() {
            return BadRequest("This was not a good request");
        }
    }
}