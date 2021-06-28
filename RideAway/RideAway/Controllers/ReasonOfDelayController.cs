using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using RideAwayBl;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RideAway.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ReasonOfDelayController : ControllerBase
    {
        InterfaceReasonOfDelayBL IReasonOfDelayBL;
            public ReasonOfDelayController(InterfaceReasonOfDelayBL IReasonOfDelayBL)
        {
            this.IReasonOfDelayBL = IReasonOfDelayBL;
        }
        // GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ValuesController>/5
        [HttpGet]
        public List<ReasonOfDelay> GetAll( )
        {
            return IReasonOfDelayBL.GetAll();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
