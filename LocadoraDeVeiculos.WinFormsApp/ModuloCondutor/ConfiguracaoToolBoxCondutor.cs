using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCondutor
{
    public class ConfiguracaoToolBoxCondutor : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Condutores";

        public override string TooltipInserir => "Inserir Condutor";

        public override string TooltipEditar => "Editar Condutor";

        public override string TooltipExcluir => "Excluir Condutor";
    }
}
