using System.ComponentModel;

namespace LocadoraDeVeiculos.Dominio.ModuloCobranca
{
    public enum TipoPlanoEnum
    {
        [Description(" ")]
        Nenhum,

        [Description("Plano Diário")]
        PlanoDiario,

        [Description("Plano Controlador")]
        PlanoControlador,

        [Description("Plano Livre")]
        PlanoLivre
    }
}
