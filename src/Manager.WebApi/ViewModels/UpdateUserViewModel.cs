using System.ComponentModel.DataAnnotations;

namespace Manager.WebApi.ViewModels
{
    public class UpdateUserViewModel
    {
        [Required(ErrorMessage ="O Id não pode ser vazio.")]
        [Range(1, long.MaxValue, ErrorMessage = "O Id deve ser maior que zero.")]
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome não pode ser vazio.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O email não pode ser vazio.")]
        [MinLength(10, ErrorMessage = "O email deve ter no mínimo 10 caracteres.")]
        [MaxLength(180, ErrorMessage = "O email deve ter no máximo 180 caracteres.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                        ErrorMessage = "O email está inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        [MaxLength(30, ErrorMessage = "A senha deve ter no máximo 30 caracteres.")]
        public string Password { get; set; }
    }
}
