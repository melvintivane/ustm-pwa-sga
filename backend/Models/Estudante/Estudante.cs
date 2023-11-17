using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("estudantes")]
public class Estudante
{
    [Key]
    public Guid Id { get; set; }
    public string? Role { get; set; } 
    public int? NrEstudante { get; set; }
    public string? Password { get; set; }
    public string? Nome { get; set; }
    public string? NumeroBI { get; set; }
}
