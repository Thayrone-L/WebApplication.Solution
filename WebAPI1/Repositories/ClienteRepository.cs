using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class ClienteRepository
    {
        private List<Cliente> clientes;

        public ClienteRepository()
        {
            // Inicialização do repositório com alguns clientes de exemplo
            clientes = new List<Cliente>
            {
                new Cliente
                {
                    Id = 1,
                    CPF = "123.456.789-01",
                    Nome = "Cliente 1",
                    RG = "1234567",
                    DataExpedicao = new DateTime(2000, 1, 1),
                    OrgaoExpedicao = "SSP",
                    UfExpedicao = "SP",
                    DataNascimento = new DateTime(1990, 5, 15),
                    Sexo = "M",
                    EstadoCivil = "Solteiro",
                    endereco = new Endereco
                    {
                        CEP = "12345-678",
                        Logradouro = "Rua A",
                        Numero = "123",
                        Complemento = "Apto 4",
                        Bairro = "Centro",
                        Cidade = "São Paulo",
                        UF = "SP"
                    }
                },
                new Cliente
                {
                    Id = 2,
                    CPF = "987.654.321-09",
                    Nome = "Cliente 2",
                    RG = "7654321",
                    DataExpedicao = new DateTime(2001, 2, 2),
                    OrgaoExpedicao = "SSP",
                    UfExpedicao = "RJ",
                    DataNascimento = new DateTime(1985, 8, 20),
                    Sexo = "F",
                    EstadoCivil = "Casado",
                    endereco = new Endereco
                    {
                        CEP = "54321-987",
                        Logradouro = "Avenida B",
                        Numero = "456",
                        Complemento = "Casa 2",
                        Bairro = "Centro",
                        Cidade = "Rio de Janeiro",
                        UF = "RJ"
                    }
                }
            };
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return clientes;
        }

        public Cliente ObterClientePorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            // Simulação de geração de novo ID
            cliente.Id = clientes.Max(c => c.Id) + 1;
            clientes.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                // Atualizar os campos do cliente existente com os valores do novo cliente
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
            }
        }

        public void ExcluirCliente(int id)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
            }
        }
    }
}
