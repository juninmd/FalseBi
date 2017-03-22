namespace FalseBI.ConsoleApp
{
    public class EntidadeNetflix
    {
        /// <summary>
        /// Id da série/filme/animação
        /// </summary>
        public int IdVideo { get; set; }

        /// <summary>
        /// País
        /// </summary>
        public int IdPais { get; set; }

        /// <summary>
        /// Categoria série/filme/animação
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Idade dos usuários
        /// </summary>
        public int Idade { get; set; }

        /// <summary>
        /// Tempo médio por dia
        /// </summary>
        public int TempoMedioDia { get; set; }
    }
}
