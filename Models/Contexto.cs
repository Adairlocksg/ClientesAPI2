using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;



namespace ClientesApi2.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { 
        }
        public DbSet<Clientes> Clientes { get; set; } = null!;

    }
}
