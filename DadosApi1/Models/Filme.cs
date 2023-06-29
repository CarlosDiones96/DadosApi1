using System.ComponentModel.DataAnnotations;

namespace DadosApi1.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Título obrigatório")]
    [StringLength(100)]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Gênero obrigatório")]
    [StringLength(20)]
    public string Genero { get; set; }

    public string Diretor { get; set; }

    [Range(70, 360)]
    public int Duracao { get; set; }
}
