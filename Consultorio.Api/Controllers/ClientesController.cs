using Consultorio.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Consultorio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Cliente>() 
            { 
                new Cliente
                {
                    Id = 1,
                    Nome = "Ricardo C. Miranda",
                    DataNascimento = new System.DateTime(1961,11,29)
                },
                  new Cliente
                {
                    Id = 2,
                    Nome = "Rachel M.C. Miranda",
                    DataNascimento = new System.DateTime(1960,03,12)
                }
            });
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}