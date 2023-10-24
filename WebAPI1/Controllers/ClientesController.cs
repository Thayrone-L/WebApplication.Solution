using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Repositories;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteDados clienteDados;

        public ClientesController(ApiDbContext dbContext)
        {
            clienteDados = new ClienteDados(dbContext);
        }

        [HttpGet("obterclientes")]
        public IEnumerable<Cliente> GetClientes()
        {
            return clienteDados.ObterClientes();
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            Cliente cliente = clienteDados.ObterClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult PostCliente(Cliente cliente)
        {
            clienteDados.AdicionarCliente(cliente);
            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            Cliente clienteExistente = clienteDados.ObterClientePorId(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteDados.AtualizarCliente(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            Cliente clienteExistente = clienteDados.ObterClientePorId(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteDados.ExcluirCliente(id);
            return NoContent();
        }

        [HttpGet("total")]
        public IActionResult GetTotalClientes()
        {
            int totalClientes = clienteDados.ObterTotalClientes();
            return Ok(totalClientes);
        }
    }
}
