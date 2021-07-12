using IoTBussiness.Abstract;
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
    public class VehicleController : ControllerBase
    {
        IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("getAllVehicle")]
        public ActionResult GetAllVehicle()
        {
            var result = _vehicleService.GetAllVehicles();
            if (result.Data.Count>=0)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpGet("getVehicleById")]
        public ActionResult GetVehicle(int vehicleId)
        {
            var result = _vehicleService.GetVehicle(vehicleId);
            if (result.Data!= null)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

        [HttpPost("addVehicle")]
        public ActionResult AddVehicle([FromBody]Vehicle vehicle)
        {
            if (vehicle!=null)
            {
                var result=_vehicleService.Add(vehicle);
                return Ok(result.Message);
            }
            return BadRequest();
        }
        [HttpPost("deleteVehicle")]
        public ActionResult DeleteVehicle(int vehicleId)
        {
            var result = _vehicleService.GetVehicle(vehicleId);
            if (result.Data!=null)
            {
                var message= _vehicleService.Delete(result.Data);
                return Ok(message.Message);
            }
            return BadRequest();
        }
    }
}
