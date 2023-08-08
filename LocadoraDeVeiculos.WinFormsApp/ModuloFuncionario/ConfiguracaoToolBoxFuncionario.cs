using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloFuncionario
{
    public class ConfiguracaoToolBoxFuncionario : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Funcionario";

        public override string TooltipInserir => "Inserir Funcionario";

        public override string TooltipEditar => "Editar Funcionario";

        public override string TooltipExcluir => "Excluir Funcionario";

        public virtual bool FiltrarHabilitado { get { return false; } }

        public virtual bool PrecoHabilitado { get { return false; } }
    }
}
