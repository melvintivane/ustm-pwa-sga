namespace pwa_trabalho_sga.Models.Estudante
{
    public class Estudante {
        public Guid Id { get; set; }
        public int NrEstudante { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }
        public string Curso { get; set; }
        public string Notas { get; set; }
        public string Exames { get; set; }
    }
}