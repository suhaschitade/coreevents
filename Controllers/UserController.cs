using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using events.Models;

namespace events.Controllers
{
    [Route("api/[controller]")]
    public class UserController :  Controller
    {
        private readonly EventsContext _context;

        public UserController(EventsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUser()
        {
            return _context.Users.ToList();
        }
        [HttpGet("{id}",Name="GetUser")                 ]
        public IActionResult GetUserById(long id)
        {
            var usr = _context.Users.FirstOrDefault(u=>u.Id==id);
            if(usr==null)
            {
                return NotFound();
            }
        
            return new ObjectResult(usr);
        }

    }
}