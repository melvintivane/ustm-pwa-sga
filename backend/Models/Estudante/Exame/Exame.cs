using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("exames")]
public class Exame
{
    [Key]
    public Guid Id { get; set; }
    public Guid Estudante_Id { get; set; }
    public Guid Disciplina_Id { get; set; }
    public double? NotaFrequencia { get; set; }
    public double? Normal { get; set; }
    public double? Recorrencia { get; set; }
    public string? Obs { get; set; }
    public DateTime Created_At { get; set; }
}