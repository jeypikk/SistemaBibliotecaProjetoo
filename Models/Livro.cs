namespace BibliotecaSimples.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }

        private int quantidade;
        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value < 0 ? 0 : value;
        }
    }
}
