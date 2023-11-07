
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("notas")]
public class Nota
{
    [Key]
    public Guid Id { get; set; }
    public Guid Estudante_Id { get; set; }
    public Guid Disciplina_Id { get; set; }
    public double Teste1 { get; set; }
    public double Teste2 { get; set; }
    public double Trabalho1 { get; set; }
    public double Trabalho2 { get; set; }
    public double Media { get; set; }
    public string? Observacao { get; set; }
    public DateTime Created_At { get; set; }
}
