using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P2_Store.Models;
using P2_Store.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private ILogger _logger;
        private IDL _repo;
        public ReviewController(ILogger<ReviewController> logger, IDL repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            var x = _repo.ListReviews();
            return Ok(x);
        }

        //// GET: ReviewController/Details/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{

        //}

        [HttpPost]
        public IActionResult Create([FromBody] Review x)
        {


            var r = _repo.AddReview(x);
            return Ok(r);

        }

        //weird
        [HttpDelete("{id}")]
        public IActionResult Delete(Review review)
        {
            var x = _repo.DeleteReview(review);

            return Ok(x);
        }
    }
}
