using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }


    [Required(ErrorMessage = "O título do gênero é obrigatório")]
    [StringLength(30, ErrorMessage = "O tamanho do gênero não pode exceder 30 caracteres")]
    public string Genero { get; set; }


    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
