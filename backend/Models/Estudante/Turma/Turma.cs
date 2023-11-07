
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("turmas")]
public class Turma
{
    [Key]
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Semestre { get; set; }
    public string? Ano { get; set; }
    public string? Periodo { get; set; }
    public DateTime Created_At { get; set; }
}