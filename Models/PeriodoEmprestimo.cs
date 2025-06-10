namespace BibliotecaSimples.Models
{
    public struct PeriodoEmprestimo
    {
        public DateTime Inicio;
        public DateTime? Fim;

        public PeriodoEmprestimo(DateTime inicio)
        {
            Inicio = inicio;
            Fim = null;
        }
    }
}
