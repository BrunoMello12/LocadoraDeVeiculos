using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public class ConfiguracaoToolBoxAluguel : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Aluguel";

        public override string TooltipInserir => "Inserir Aluguel";

        public override string TooltipEditar => "Editar Aluguel";

        public override string TooltipExcluir => "Excluir Aluguel";
    }
}
