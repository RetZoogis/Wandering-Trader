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
    public class OrderController : ControllerBase
    {

        private ILogger _logger;
        private IDL _repo;
        public OrderController(ILogger<OrderController> logger, IDL repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            var x = _repo.ListOrders();
            return Ok(x);
        }


        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var x = _repo.GetOrderById(id);

                return Ok(x);
            }

            catch
            {
                return Ok("It does not exist");
            }
        }
        [HttpGet("{id}/{comp}")]
        public IActionResult Get(int id, bool comp)
        {
            Order y = new Order();
            try
            {
                List<Order> x = _repo.GetOrderById(id);
                if(comp == false)
                {
                y = x.FirstOrDefault(x => x.IsCompleted == 0);
                    if(y == null)
                    {
                        y = _repo.AddOrder(id);
                        return Ok(y);
                    }
                    return Ok(y);
                }
                else
                {
                return Ok(x);

                }
            }

            catch
            {
                return NotFound("It does not exist");
            }
        }
/*        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Create([FromBody] Order x)
        {
            var r =  _repo.AddOrder(x);

            return Ok(r);

        }*/

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Order id)
        {
            var x = _repo.DeleteOrder(id);

            return Ok(x);

        }
    }
}
