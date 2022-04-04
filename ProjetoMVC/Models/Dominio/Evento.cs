using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models.Dominio
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        public string Local { get; set; }

        [Display(Name ="Data Evento")]
        public DateTime DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [MinLength(3, ErrorMessage = "{0} deve ter no mínimo 4 caracteres")]
        [MaxLength(50, ErrorMessage = "{0} deve ter no maximo 50 caracteres")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [Display(Name = "Quantidade de Pessoas")]
        [Range(1, 120000, ErrorMessage = "A {0} deve ser de 1 a 120.000 pessoas")]
        public int QtdPessoas { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimenro obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "e-mail")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public bool Exclusivo { get; set; }
    }
}
