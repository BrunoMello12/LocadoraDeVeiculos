using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCupom
{
    public class ConfiguracaoToolBoxCupom : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Cupom";

        public override string TooltipInserir => "Inserir Cupom";

        public override string TooltipEditar => "Editar Cupom";

        public override string TooltipExcluir => "Excluir Cupom";

        public virtual bool FiltrarHabilitado { get { return false; } }

        public virtual bool PrecoHabilitado { get { return false; } }
    }
}
