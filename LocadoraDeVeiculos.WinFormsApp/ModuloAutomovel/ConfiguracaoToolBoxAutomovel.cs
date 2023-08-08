using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel
{
    public class ConfiguracaoToolBoxAutomovel : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Automóveis";

        public override string TooltipInserir => "Inserindo novo Automóvel";

        public override string TooltipEditar => "Editar um Automóvel";

        public override string TooltipExcluir => "Excluir um Automóvel";
    }
}
