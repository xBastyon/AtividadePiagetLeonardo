namespace PiagetLeonardo.Models
{
    /// <summary>
    /// Aluno Leonardo
    /// </summary>
    public class Aluno
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Escola { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? RGM { get; set; }
        public DateTime Idade { get; set; }
        public decimal Notas { get; set; }
        public string? Professor { get; set; }
    }
}
