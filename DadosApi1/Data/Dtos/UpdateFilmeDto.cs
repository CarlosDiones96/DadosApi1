using System.ComponentModel.DataAnnotations;

namespace DadosApi1.Data.Dtos;

public class UpdateFilmeDto
{
    [Required]
    [StringLength(50)]
    public string Titulo { get; set; }

    [Required]
    [Range(70, 360)]
    public int Duracao { get; set; }

    public string Diretor { get; set; }
    public string Genero { get; set; }
}
