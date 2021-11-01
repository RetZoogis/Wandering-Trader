using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P2_Store.Models;
using P2_Store.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P2_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        private IDL _repo;
        public UserController(ILogger<UserController> logger, IDL repo)
        {
            _logger = logger;
            _repo = repo;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var x = _repo.ListUsers();

            return Ok(x);

        }

/*        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var x = _repo.GetUserById(id);
                return Ok(x);
            }

            catch
            {
                return Ok("It does not exist");
            }


        }*/
        
        // POST api/<UserController>
        
        [HttpPost("{create}")]
        public IActionResult Create([FromBody] User x, bool create)
        {
           User foundUser = _repo.GetUserByEmail(x.Email);
            bool check;
            if (create == false)
            {
                try
                {
                    check = _repo.CheckUserCredentials(x, foundUser);
                    if (check)
                    {
                        return Ok(foundUser);
                    }
                    else
                    {
                        return NotFound("User with this email was not found");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                if(foundUser == null)
                {
                    _repo.AddUser(x);
                }
                else
                {
                    return BadRequest("A user with that email already exists");
                }
                User createdUser = _repo.GetUserByEmail(x.Email);
                return Ok(createdUser);
            }

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            

        }

        
        // GET api/<InventoryController>/5
        [HttpGet("{mail}")]
        public IActionResult Get(string mail)
        {
            try
            {
                var x = _repo.GetUserByEmail(mail);
                return Ok(x);
                
            }

            catch
            {
                return Ok("It does not exist");
            }

        }
        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(User id)
        {
            var x = _repo.DeleteUser(id);
            return Ok(x);

        }
    }
}
