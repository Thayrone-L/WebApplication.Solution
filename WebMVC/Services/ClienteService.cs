using System;
using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class ClienteService
    {
        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            for (int i = 1; i <= 50; i++)
            {
                clientes.Add(new Cliente
                {
                    Id = i,
                    Nome = $"Cliente {i}",
                    CPF = $"123.456.789-0{i}",
                    DataNascimento = new DateTime(1990 + i, 1, 1),
                    Sexo = (i % 2 == 0) ? "Masculino" : "Feminino",
                    EstadoCivil = (i % 2 == 0) ? "Solteiro" : "Casado",
                    RG = $"12345{i}",
                    OrgaoExpedicao = "SSP",
                    UfExpedicao = "SP",
                    DataExpedicao = new DateTime(2000 + i, 1, 1),
                    endereco = new Endereco
                    {
                        CEP = "12345-678",
                        Logradouro = $"Rua {i}",
                        Numero = i.ToString(),
                        Complemento = $"Apto {i}",
                        Bairro = "Centro",
                        Cidade = "São Paulo",
                        UF = "SP"
                    }
                });
            }

            return clientes;
        }
    }
}
