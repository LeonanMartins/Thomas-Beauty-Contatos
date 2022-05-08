using Microsoft.EntityFrameworkCore;

namespace TBContatos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        public DbSet<Contato> Contato { get; set; }
    }
}
