using FluentValidation;
using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxasServicos
{
    public class ValidadorTaxasServicos : AbstractValidator<TaxasServicos>, IValidadorTaxasServicos
    {
        public ValidadorTaxasServicos()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.Preco)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(x => x.PrecoFixo)
            .NotEqual(false).When(x => !x.PrecoDiaria)
            .WithMessage("Selecione um Plano primeiro!");

        }
    }
}
