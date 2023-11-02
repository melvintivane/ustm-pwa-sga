using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("estudante")]
public class Estudante
{
    [Key]
    public Guid Id { get; set; }
    public UserRole Role = UserRole.Estudante;
    public int? NrEstudante { get; set; }
    public string? Password { get; set; }
    public string? Nome { get; set; }
    public string? Turma { get; set; }
    public string? Curso { get; set; }
    public string? Notas { get; set; }
    public string? Exames { get; set; }
}
