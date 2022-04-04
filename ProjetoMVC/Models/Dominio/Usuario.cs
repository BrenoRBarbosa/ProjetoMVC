using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models.Dominio
{
    public class Usuario
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Nome de Usuário")]
        [Required(ErrorMessage = "O campo {0} é de prenchimento obrigatório")]
        public string NomeUsuario { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} dee ter {1} digitos")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
