using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThumbsUp.API.Data;

namespace ThumbsUp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase // this inherits form contrller base class which gives us access to http responses and actions that we can use inside our contrller like IactionResult
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }

        [AllowAnonymous]
        // GET api/values
        [HttpGet]
        //the Iactionresult allows to return http responses
        //synchrous code means when a a request comes into our application a thread can be blocked until the call is made to the db and the db has returned the values back and it would not be able to handle any other requests
        //async so the thread is not block and is kept open for a request to be handled when there is a request
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();// await will wait for a response

            return Ok(values);
        }

        [AllowAnonymous]
        // GET api/values/5
        [HttpGet("{id}")]
         public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
