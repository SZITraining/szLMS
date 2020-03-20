using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class CoursesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> GetCoursesAsync()
        {
            var _data = await StuffAsync();

            return Json(_data);
        }

        static async Task<object> StuffAsync()
        {
            var _data1 = await Task.FromResult<object>(new { name = "test", date = "stuff" });
            var _data2 = await Task.FromResult<object>(new { name = "test", date = "stuff" });

            IList _data3 = new List<object>();

            _data3.Add(_data1);
            _data3.Add(_data2);


            return _data3;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
