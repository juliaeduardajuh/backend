using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD.Models;
namespace _19_Atividade_CRUD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //No meu DbSet carregará todos os jogos salvos no banco de dados
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}