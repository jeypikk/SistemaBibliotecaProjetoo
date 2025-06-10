using BibliotecaSimples.Models;

namespace BibliotecaSimples.Services
{
    public class Biblioteca
    {
        public List<Livro> Livros = new();
        public List<Usuario> Usuarios = new();
        public List<Emprestimo> Emprestimos = new();

        public void CadastrarLivro(string titulo, string autor, string isbn, int quantidade)
        {
            Livros.Add(new Livro { Titulo = titulo, Autor = autor, ISBN = isbn, Quantidade = quantidade });
        }

        public void CadastrarUsuario(string nome, string matricula)
        {
            Usuarios.Add(new Usuario { Nome = nome, Matricula = matricula });
        }

        public void RegistrarEmprestimo(string matricula, string isbn)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Matricula == matricula);
            var livro = Livros.FirstOrDefault(l => l.ISBN == isbn);

            if (usuario == null || livro == null || livro.Quantidade <= 0) return;

            livro.Quantidade--;
            var emprestimo = new Emprestimo
            {
                Usuario = usuario,
                Livro = livro,
                Periodo = new PeriodoEmprestimo(DateTime.Now)
            };
            Emprestimos.Add(emprestimo);
            usuario.Emprestimos.Add(emprestimo);
        }

        public void RegistrarDevolucao(string matricula, string isbn)
        {
            var emprestimo = Emprestimos.FirstOrDefault(e =>
                e.Usuario.Matricula == matricula &&
                e.Livro.ISBN == isbn &&
                e.Ativo);

            if (emprestimo != null)
            {
                emprestimo.Periodo.Fim = DateTime.Now;
                emprestimo.Livro.Quantidade++;
            }
        }

        public void ListarLivros()
        {
            Console.WriteLine("\n--- Lista de Livros ---");
            foreach (var livro in Livros)
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor} (ISBN: {livro.ISBN}) | Quantidade: {livro.Quantidade}");
            }
        }

        public void ExibirRelatorios()
        {
            Console.WriteLine("\n--- Livros Disponíveis ---");
            foreach (var livro in Livros.Where(l => l.Quantidade > 0))
                Console.WriteLine($"{livro.Titulo} - {livro.Quantidade} disponível(is)");

            Console.WriteLine("\n--- Livros Emprestados ---");
            foreach (var emprestimo in Emprestimos.Where(e => e.Ativo))
                Console.WriteLine($"{emprestimo.Livro.Titulo} emprestado para {emprestimo.Usuario.Nome}");

            Console.WriteLine("\n--- Usuários com livros ---");
            foreach (var usuario in Usuarios.Where(u => u.Emprestimos.Any(e => e.Ativo)))
                Console.WriteLine($"{usuario.Nome} ({usuario.Matricula}) com {usuario.Emprestimos.Count(e => e.Ativo)} livro(s)");
        }
    }
}
