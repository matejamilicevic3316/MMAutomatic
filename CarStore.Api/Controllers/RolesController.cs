using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Models;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly CrudMediator _mediator;
        public RolesController(CrudMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] RoleSearch search)
        {
            try
            {
                return Ok(_mediator.Search<Role,RoleDto>(search));
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

        // GET: api/Roles/5
        [HttpGet("{id}", Name = "GetRoles")]
        public IActionResult Get(int id)
        {
            try
            {
                var role = _mediator.Find<Role, RoleDto>(id);
                if (role != null)
                {
                    return Ok(role);
                }
                return NotFound();
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: api/Roles
        [HttpPost]
        public IActionResult Post([FromBody] RoleDto value)
        {
            try
            {
                _mediator.Add<Role, RoleDto>(value);
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
        public IActionResult Put(int id, [FromBody] RoleDto value)
        {
            try
            {
                value.Id = id;
                _mediator.Update<Role, RoleDto>(value);
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
                _mediator.Delete<Role>(id);
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
