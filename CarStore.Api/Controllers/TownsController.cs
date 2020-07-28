using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Models.Towns;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownsController : ControllerBase
    {
        private readonly CrudMediator _mediator;
        public TownsController(CrudMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/Town
        [HttpGet]
        public IActionResult Get([FromQuery] TownSearch search)
        {
            try
            {
                return Ok(_mediator.Search<Town, TownDto>(search));
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

        // GET: api/Town/5
        [HttpGet("{id}", Name = "GetTown")]
        public IActionResult Get(int id)
        {
            try
            {
                var town = _mediator.Find<Town, TownDto>(id);
                if (town != null)
                {
                    return Ok(town);
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

        // POST: api/Town
        [HttpPost]
        public IActionResult Post([FromBody] TownDto dto)
        {
            try
            {
                _mediator.Add<Town, TownDto>(dto);
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

        // PUT: api/Town/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TownDto dto)
        {
            try
            {
                dto.Id = id;
                _mediator.Update<Town, TownDto>(dto);
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
                _mediator.Delete<Town>(id);
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
