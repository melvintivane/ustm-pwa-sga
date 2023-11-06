
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("cursos")]
public class Curso {
    [Key]
    public Guid Id { get; set; }
    public Guid Matricula_Id { get; set; }
    public string? Nome { get; set; }
    public DateTime Created_at { get; set; }
}