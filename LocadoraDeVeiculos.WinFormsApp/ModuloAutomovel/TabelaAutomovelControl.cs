using GeradorTestes.WinApp;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel
{
    public partial class TabelaAutomovelControl : UserControl
    {
        public TabelaAutomovelControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Placa", HeaderText = "Placa", FillWeight=35F },

                new DataGridViewTextBoxColumn { Name = "Marca", HeaderText = "Marca", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "Cor", HeaderText = "Cor", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "Modelo", HeaderText = "Modelo", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "TipoCombustivel", HeaderText = "Tipo Combustivel", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "GrupoDoAutomovel", HeaderText = "Grupo Do Automovel", FillWeight=25F },
            };

            return colunas;
        }

        internal void AtualizarRegistros(List<Automovel> automoveis)
        {
            grid.Rows.Clear();

            foreach (var automovel in automoveis)
            {
                grid.Rows.Add(automovel.Id, automovel.Placa, automovel.Marca, automovel.Cor, automovel.Modelo, automovel.TipoCombustivel.ToString(), automovel.GrupoDoAutomovel.ToString());
            }
        }

        internal Guid ObtemIdSelecionado()
        {
            return grid.SelecionarId();
        }
    }
}
