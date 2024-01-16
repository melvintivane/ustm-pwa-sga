
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("disciplinas")]
public class Disciplina
{
    [Key]
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public DateTime Created_At { get; set; }
}