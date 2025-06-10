namespace BibliotecaSimples.Models
{
    public class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public PeriodoEmprestimo Periodo { get; set; }
        public bool Ativo => Periodo.Fim == null;
    }
}
