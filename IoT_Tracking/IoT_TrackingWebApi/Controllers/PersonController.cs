using IoTBussiness.Abstract;
using IoTCore.Utilities;
using IoTCore.Utilities.Results;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_TrackingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("getAllPerson")]
        public ActionResult GetPerson()
        {
            var result = _personService.GetAllPerson();
            if (result.Data!=null)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getPersonelById")]
        public ActionResult GetPerson(int Id)
        {
            var result = _personService.GetPerson(Id);
            if (result.Data!=null)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("addPerson")]
        public ActionResult AddPerson([FromBody]Person person)
        {
            var result = _personService.Add(person);
            return Ok(result.Message);
        }
        [HttpPost("deletePerson")]
        public ActionResult DeletePerson(int personId)
        {
            var person = _personService.GetPerson(personId);
            if (person.Data!=null)
            {
                _personService.Delete(person.Data);
                return Ok(person.Message);
            }
            return BadRequest();
        }
    }
}
