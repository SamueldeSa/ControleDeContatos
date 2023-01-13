using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {

        //injetar DbContextOptions e tipar ele como BancoContext -- injeção
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }   
    }
}
