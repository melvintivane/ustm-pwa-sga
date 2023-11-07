
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("turma_disciplina")]
public class Turma_Disciplina {
    [Key]
    public Guid Id { get; set; }
    public Guid Turma_Id { get; set; }
    public Guid Disciplina_Id { get; set; }
    public DateTime Created_At { get; set; }
}