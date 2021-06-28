using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities;
using RideAwayBl;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RideAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        InterfacePassengerBL IPassengerBl;


        public PassengerController(InterfacePassengerBL IPassengerBl)
        {
            this.IPassengerBl = IPassengerBl;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public int Get()
        {
            return IPassengerBl.numOfPassengersBL();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{Passengers}")]
        public List<Passenger> GetPassengers()
        {
            return IPassengerBl.GetPassengers();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Passenger passenger)
        {
           IPassengerBl.AddPassenger(passenger);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string view)
        {
           
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
