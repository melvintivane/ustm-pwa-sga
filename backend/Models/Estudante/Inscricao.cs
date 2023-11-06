
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pwa_trabalho_sga.Models;

[Table("inscricoes")]
public class Inscricao {
    [Key]
    public Guid Id { get; set; }
    public Guid Estudante_Id { get; set; }
    public Guid Turma_Id { get; set; }
    public DateTime Created_At { get; set; }

}