using System.Linq;
using Microsoft.EntityFrameworkCore;
using WCFServiceHost1.Dados.Dao;

namespace WCFServiceHost1
{
    public class ClienteService : IClienteService
    {
        private WcfDbContext dbContext; 

        public ClienteService(WcfDbContext context)
        {
            dbContext = context;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();
        }

        public Cliente ObterClientePorId(int id)
        {
            return dbContext.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            dbContext.Entry(cliente).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void ExcluirCliente(int id)
        {
            var cliente = dbContext.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                dbContext.Clientes.Remove(cliente);
                dbContext.SaveChanges();
            }
        }

        public int ContarClientes()
        {
            return dbContext.Clientes.Count();
        }

        public Cliente ObterClientePorId(string id)
        {
            throw new NotImplementedException();
        }

        public void ExcluirCliente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
