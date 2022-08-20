using Microsoft.EntityFrameworkCore;
using TrabalhandoComEntity.Controllers.Entities;

namespace TrabalhandoComEntity.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos { get; set;}
    }
}