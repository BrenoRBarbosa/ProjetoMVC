using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models.Dominio
{
    public class CadastroUsuario
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

        [DataType(DataType.Password)]
        [MaxLength(16, ErrorMessage = "O tamanho máximo do campo {0} é de {1}")]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo {0} é de {1}")]
        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(16, ErrorMessage = "O tamanho máximo do campo {0} é de {1}")]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo {0} é de {1}")]
        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [Compare(nameof(Senha), ErrorMessage = "A confirmação da senha não confere")]
        public string ConfSenha { get; set; }
    }
}
