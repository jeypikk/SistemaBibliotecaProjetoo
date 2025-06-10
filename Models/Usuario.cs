namespace BibliotecaSimples.Models
{
    public class Usuario : Pessoa
    {
        public string Matricula { get; set; }
        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
    }
}
