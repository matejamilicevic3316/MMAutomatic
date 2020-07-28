using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Models.Vehicles;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly CrudMediator _mediator;
        public VehiclesController(CrudMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Vehicless
        [HttpGet]
        public IActionResult Get([FromQuery] VehicleSearch search)
        {
            try
            {
                return Ok(_mediator.Search<Vehicle, VehicleDto>(search));
            }
            catch (UnexistingColumnException e)
            {
                return BadRequest(e.Error);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // GET: api/Vehicless/5
        [HttpGet("{id}", Name = "GetVehicless")]
        public IActionResult Get(int id)
        {
            try
            {
                var vehicle = _mediator.Find<Vehicle, VehicleDto>(id);
                if (vehicle != null)
                {
                    return Ok(vehicle);
                }
                return NotFound();
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST: api/Roles
        [HttpPost]
        public IActionResult Post([FromBody] VehicleDto value)
        {
            try
            {
                _mediator.Add<Vehicle, VehicleDto>(value);
                return Ok();
            }
            catch (CrudValidationException e)
            {
                return UnprocessableEntity(e.Errors);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] VehicleDto value)
        {
            try
            {
                value.Id = id;
                _mediator.Update<Vehicle, VehicleDto>(value);
                return Ok();
            }
            catch (CrudValidationException e)
            {
                return UnprocessableEntity(e.Errors);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _mediator.Delete<Vehicle>(id);
                return Ok();
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return Conflict(e);
            }
        }
    }
}
