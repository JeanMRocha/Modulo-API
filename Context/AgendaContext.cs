using Microsoft.EntityFrameworkCore;
using Modulo_API.Entities; // Atualize se necessário

namespace Modulo_API.Context
{
    public class AgendaContext : DbContext 
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {} 
        
        public DbSet<Contato> Contatos { get; set; }
    }
}
