using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxasServicos
{
    public class TaxasServicos : EntidadeBase<TaxasServicos>
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool PrecoFixo { get; set; }
        public bool PrecoDiaria { get; set; }

        public List<Aluguel> ListaAlugueis { get; set; }

        public TaxasServicos()
        {
        }
        public TaxasServicos(string nome)
        {
            Nome = nome;
        }

        public TaxasServicos(string nome)
        {
            Nome = nome;
            ListaAlugueis = new List<Aluguel>();
        }

        public TaxasServicos(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            ListaAlugueis = new List<Aluguel>();
        }

        public override void Atualizar(TaxasServicos registro)
        {
            Nome = registro.Nome;
            Preco = registro.Preco;
        }
    }
}
