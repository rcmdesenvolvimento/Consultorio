using Consultorio.Core.Domain;
using Consultorio.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Consultorio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager _clienteManager;
        public ClientesController(IClienteManager clienteManager)
        {
            _clienteManager = clienteManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _clienteManager.GetClientesAsync());

            //return Ok(new List<Cliente>()
            //{
            //    new Cliente
            //    {
            //        Id = 1,
            //        Nome = "Ricardo C. Miranda",
            //        DataNascimento = new System.DateTime(1961,11,29)
            //    },
            //      new Cliente
            //    {
            //        Id = 2,
            //        Nome = "Rachel M.C. Miranda",
            //        DataNascimento = new System.DateTime(1960,03,12)
            //    }
            //});
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _clienteManager.GetClientesAsync(id);

            if(result == null)
            {
                return BadRequest("Resgistro não encontrado \n "+
                    "Status : "+HttpStatusCode.BadRequest.ToString()+" \n"+
                    "Data   :"+DateTime.UtcNow);
            }

            return Ok(await _clienteManager.GetClientesAsync(id));
        }

        private IActionResult BadRequest(string v, HttpStatusCode badRequest)
        {
            throw new NotImplementedException();
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