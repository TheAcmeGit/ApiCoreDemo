using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiCoreDemo.Controllers
{
    [Produces("application/json")]//支持此种相应类型
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        private readonly ILogger _logger;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        // GET: api/ToDo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.Log(LogLevel.Information, "日志测试");
            return new string[] { "value1", "value2" };
        }

        // GET: api/ToDo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ToDo
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ToDo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
