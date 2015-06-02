
namespace TurboRango.Dominio
{
    internal class Restaurante
    {
        internal string Nome { get; set; }

        internal int Capacidade { get; set; }

        internal Categoria Categoria { get; set; }

        internal Localizacao Localizacao { get; set; }

        internal Contato Contato { get; set; }
    }
}