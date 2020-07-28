using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using BusinessLogic.Models.VehicleTypes;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly CrudMediator _mediator;
        public VehicleTypesController(CrudMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/VehicleTypess
        [HttpGet]
        public IActionResult Get([FromQuery] VehcileTypeSearch search)
        {
            try
            {
                return Ok(_mediator.Search<VehicleType, VehicleTypeDto>(search));
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

        // GET: api/VehicleTypess/5
        [HttpGet("{id}", Name = "GetVehicleTypess")]
        public IActionResult Get(int id)
        {
            try
            {
                var type = _mediator.Find<VehicleType, VehicleTypeDto>(id);
                if (type != null)
                {
                    return Ok(type);
                }
                return NotFound();
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

        // POST: api/Roles
        [HttpPost]
        public IActionResult Post([FromBody] VehicleTypeDto value)
        {
            try
            {
                _mediator.Add<VehicleType, VehicleTypeDto>(value);
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
        public IActionResult Put(int id, [FromBody] VehicleTypeDto value)
        {
            try
            {
                value.Id = id;
                _mediator.Update<VehicleType, VehicleTypeDto>(value);
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
                _mediator.Delete<VehicleType>(id);
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
