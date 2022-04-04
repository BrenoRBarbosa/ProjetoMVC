using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models.Dominio
{
    public class EventoUsuario
    {
        [Key]
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
