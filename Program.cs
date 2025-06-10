using BibliotecaSimples.Services;

class Program
{
    static void Main()
    {
        var biblioteca = new Biblioteca();
        string opcao;

        do
        {
            Console.WriteLine("\n--- Menu Biblioteca ---");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Usuário");
            Console.WriteLine("3. Registrar Empréstimo");
            Console.WriteLine("4. Registrar Devolução");
            Console.WriteLine("5. Listar Livros");
            Console.WriteLine("6. Relatórios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Título: "); var titulo = Console.ReadLine();
                    Console.Write("Autor: "); var autor = Console.ReadLine();
                    Console.Write("ISBN: "); var isbn = Console.ReadLine();
                    Console.Write("Quantidade: "); var qtd = int.Parse(Console.ReadLine());
                    biblioteca.CadastrarLivro(titulo, autor, isbn, qtd);
                    break;

                case "2":
                    Console.Write("Nome: "); var nome = Console.ReadLine();
                    Console.Write("Matrícula: "); var mat = Console.ReadLine();
                    biblioteca.CadastrarUsuario(nome, mat);
                    break;

                case "3":
                    Console.Write("Matrícula do usuário: "); var m1 = Console.ReadLine();
                    Console.Write("ISBN do livro: "); var i1 = Console.ReadLine();
                    biblioteca.RegistrarEmprestimo(m1, i1);
                    break;

                case "4":
                    Console.Write("Matrícula do usuário: "); var m2 = Console.ReadLine();
                    Console.Write("ISBN do livro: "); var i2 = Console.ReadLine();
                    biblioteca.RegistrarDevolucao(m2, i2);
                    break;

                case "5":
                    biblioteca.ListarLivros();
                    break;

                case "6":
                    biblioteca.ExibirRelatorios();
                    break;
            }

        } while (opcao != "0");
    }
}
