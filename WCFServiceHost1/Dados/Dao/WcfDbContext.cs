using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceHost1.Dados.Dao
{
    public class WcfDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public WcfDbContext(DbContextOptions<WcfDbContext> options)
            : base(options)
        {
        }
    }
}