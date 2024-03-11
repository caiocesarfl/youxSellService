using Microsoft.EntityFrameworkCore;
using Produto.Model;


namespace Produto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

    }
}
