using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessLogic.Models.Features;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly CrudMediator _mediator;

        public FeaturesController(CrudMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Features
        [HttpGet]
        public IActionResult Get([FromQuery] FeatureSearch search)
        {
            try
            {
                return Ok(_mediator.Search<Feature, FeatureDto>(search));
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

        // GET: api/Features/5
        [HttpGet("{id}", Name = "GetFeature")]
        public IActionResult Get(int id)
        {
            try
            {
                var feature = _mediator.Find<Feature, FeatureDto>(id);
                if (feature != null)
                {
                    return Ok(feature);
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

        // POST: api/Features
        [HttpPost]
        public IActionResult Post([FromBody] FeatureDto dto)
        {
            try
            {
                _mediator.Add<Feature, FeatureDto>(dto);
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

        // PUT: api/Features/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FeatureDto dto)
        {
            try
            {
                dto.Id = id;
                _mediator.Update<Feature, FeatureDto>(dto);
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
                _mediator.Delete<Feature>(id);
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
