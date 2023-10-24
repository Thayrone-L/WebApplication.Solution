using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Data
{
    public class ClienteDados
    {
        private readonly ApiDbContext _dbContext;

        public ClienteDados(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return _dbContext.Clientes;
        }

        public Cliente ObterClientePorId(int id)
        {
            return _dbContext.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = _dbContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.CPF = cliente.CPF;
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.RG = cliente.RG;
                clienteExistente.DataExpedicao = cliente.DataExpedicao;
                clienteExistente.OrgaoExpedicao = cliente.OrgaoExpedicao;
                clienteExistente.UfExpedicao = cliente.UfExpedicao;
                clienteExistente.DataNascimento = cliente.DataNascimento;
                clienteExistente.Sexo = cliente.Sexo;
                clienteExistente.EstadoCivil = cliente.EstadoCivil;
                clienteExistente.endereco = cliente.endereco;

                _dbContext.SaveChanges();
            }
        }

        public void ExcluirCliente(int id)
        {
            var clienteExistente = _dbContext.Clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente != null)
            {
                _dbContext.Clientes.Remove(clienteExistente);
                _dbContext.SaveChanges();
            }
        }

        public int ObterTotalClientes()
        {
            return _dbContext.Clientes.Count();
        }
    }
}
