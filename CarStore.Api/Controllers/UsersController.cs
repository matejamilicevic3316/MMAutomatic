using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Models.Users;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CrudMediator _crudMediator;
        public UsersController(CrudMediator mediator)
        {
            _crudMediator = mediator;
        }
        // GET: api/Users
        [HttpGet]
        public IActionResult Get([FromQuery] UserSearch search)
        {
            try
            {
                return Ok(_crudMediator.Search<User, ReadUserDto>(search));
            }
            catch (UnexistingColumnException e)
            {
                return BadRequest(e.Error);
            }
            catch (Exception e )
            {
                return StatusCode(500);
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "GetUsers")]
        public IActionResult Get(int id)
        {
            try
            {
                var user = _crudMediator.Find<User, ReadUserDto>(id);
                if (user != null)
                {
                    return Ok(user);
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

        // POST: api/Users
        [HttpPost]
        public IActionResult Post([FromBody] UserDto dto)
        {
            try
            {
                _crudMediator.Add<User, UserDto>(dto);
                 return Ok();
            }
            catch (CrudValidationException e)
            {
                return UnprocessableEntity(e.Errors);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserDto dto)
        {
            try
            {
                dto.Id = id;
                _crudMediator.Update<User, UserDto>(dto);
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
                _crudMediator.Delete<User>(id);
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
