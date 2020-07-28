using System;
using BusinessLogic.Models.Ads;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly CrudMediator _mediator;
        public AdsController(CrudMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Ads
        [HttpGet]
        public IActionResult Get([FromQuery] AdsSearch search)
        {
            try
            {
                return Ok(_mediator.Search<Ad, ReadAdDto>(search));
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

        // GET: api/Ads/5
        [HttpGet("{id}", Name = "GetAds")]
        public IActionResult Get(int id)
        {
            try
            {
                var ad = _mediator.Find<Ad, ReadAdDto>(id);
                if (ad != null)
                {
                    return Ok(ad);
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
        public IActionResult Post([FromBody] AdDto value)
        {
            try
            {
                _mediator.Add<Ad, AdDto>(value);
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
        public IActionResult Put(int id, [FromBody] AdDto value)
        {
            try
            {
                value.Id = id;
                _mediator.Update<Ad, AdDto>(value);
                return Ok();
            }
            catch (NotFoundException)
            {
                return NotFound();
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

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _mediator.Delete<Ad>(id);
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
