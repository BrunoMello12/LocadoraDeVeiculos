using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public class ConfiguracaoToolBoxAluguel : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Aluguel";

        public override string TooltipInserir => "Inserir Aluguel";

        public override string TooltipEditar => "Editar Aluguel";

        public override string TooltipExcluir => "Excluir Aluguel";

        public override string TooltipPrecos => "Configurar Precos";

        public override string TooltipDevolucao => "Devolução de Aluguel";

        public override bool FiltrarHabilitado { get { return false; } }

        public override bool PrecoHabilitado { get { return true; } }

        public override bool DevolucaoHabilitado { get { return true; } }

    }
}
