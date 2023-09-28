using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcWebIdentity.Entities;

namespace MvcWebIdentity.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos {get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // configure a forma como as entidades do seu modelo são mapeadas
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
            new Aluno{
                AlunoId = 1,
                Nome = "Leonardo",
                Email = "leodsmf@gmail.com",
                Idade = 21,
                Curso = "Engenharia"

            });
        }
    }
}
