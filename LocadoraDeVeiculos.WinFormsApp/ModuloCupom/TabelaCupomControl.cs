using GeradorTestes.WinApp;
using LocadoraDeVeiculos.Dominio.ModuloCupom;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCupom
{
    public partial class TabelaCupomControl : UserControl
    {
        public TabelaCupomControl()
        {
            InitializeComponent();

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Data", HeaderText = "Data Validade", FillWeight=85F },

                new DataGridViewTextBoxColumn { Name = "Parceiro", HeaderText = "Parceiro", FillWeight=85F },

            };

            return colunas;
        }

        internal void AtualizarRegistros(List<Cupom> cupons)
        {
            grid.Rows.Clear();

            foreach (Cupom cupom in cupons)
            {
                grid.Rows.Add(cupom.Id, cupom.Nome, cupom.Valor, cupom.DataValidade, cupom.Parceiro);
            }
        }

        public Guid ObtemIdSelecionado()
        {
            return grid.SelecionarId();
        }
    }
}
