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
    public class CategoryController : ControllerBase
    {
        private ILogger _logger;
        private IDL _repo;
        public CategoryController(ILogger<CategoryController> logger, IDL repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            var x = _repo.ListCategory();
            return Ok(x);

        }

        //// GET api/<CategoryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}


        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Create([FromBody] Category x)
        {


            var r =  _repo.AddCategory(x);
            return Ok(r);

        }

        //// PUT api/<CategoryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}



        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Category id)
        {
            var x = _repo.DeleteCategory(id);

            return Ok(x);
        }
    }
}
