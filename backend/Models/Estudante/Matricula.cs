
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("matriculas")]
public class Matricula {
    [Key]
    public Guid Id { get; set; }
    public Guid Estudante_Id { get; set; }
    public int Numero { get; set; }
    public string? Estado { get; set; }
    public DateTime Created_At { get; set; }
}