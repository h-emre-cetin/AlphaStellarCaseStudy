using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaStellarCaseStudy.BussinessLogic.Abstract;
using Entities;

namespace AlphaStellarCaseStudy.Controllers
{
    [ApiController]
    [Route("[controller]" + "/" + "[action]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleBusinessLogic _vehicleBusinessLogic;
        public VehicleController(IVehicleBusinessLogic vehicleBusinessLogic)
        {
            _vehicleBusinessLogic = vehicleBusinessLogic;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> GetCarsByColor(string color)
        {
            var carList = _vehicleBusinessLogic.GetCarsByColor(color);
            return Ok(carList);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> GetBusesByColor(string color)
        {
            var busList = _vehicleBusinessLogic.GetBusesByColor(color);
            return Ok(busList);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> GetBoatsByColor(string color)
        {
            var boatList = _vehicleBusinessLogic.GetBoatsByColor(color);
            return Ok(boatList);
        }

        [HttpPost]
        public ActionResult SwitchHeadlights(int id, bool turnOnOff)
        {
            var res = _vehicleBusinessLogic.SwitchHeadlights(id, turnOnOff);
			if (res)
			{
                return Ok(res);
			}
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteCarById(int id)
        {
            var res = _vehicleBusinessLogic.DeleteCarById(id);
            if (res)
                return Ok(res);

            return BadRequest();
        }
    }
}
