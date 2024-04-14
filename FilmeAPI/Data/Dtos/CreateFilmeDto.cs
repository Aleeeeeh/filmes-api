using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Titulo { get; set; } = null!;
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do genêro não pode exceder 50 caracteres")]
        public string Genero { get; set; } = null!;
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos")]
        public int Duracao { get; set; }
    }
}
