﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewProjectRestPrj.Model;
using NewProjectRestPrj.Business;

namespace NewProjectRestPrj.Controllers
{
    //[ApiController]
    //[ApiVersion("1")]
    //[Route("api/[controller]/v{version:apiVersion}")]

    //[Route("api/[controller]/v{version:apiVersion}")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class PersonController : ControllerBase
    {

        private IPersonBusiness _personService;

        public PersonController(IPersonBusiness personService)
        {
            _personService = personService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person); 
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
