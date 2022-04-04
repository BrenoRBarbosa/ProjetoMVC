
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models.Dominio;

namespace ProjetoMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }


        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CadastroUsuario> CadastroUsuarios { get; set; }
        public DbSet<Usuario> Usuario { get; set; } 
        public DbSet<EventoUsuario> EventoUsuario { get; set; }

    } 
}
