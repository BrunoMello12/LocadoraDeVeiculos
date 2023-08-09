using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class ValidadorAluguel : AbstractValidator<Aluguel>, IValidadorAluguel
    {
        public ValidadorAluguel()
        {
            RuleFor(x => x.Condutor)
                .NotNull().NotEmpty();

            RuleFor(x => x.GrupoAutomoveis)
                .NotNull().NotEmpty(); 

            RuleFor(x => x.Cobranca)
                .NotNull().NotEmpty(); 

            RuleFor(x => x.Automovel)
                .NotEmpty().NotEmpty();

            RuleFor(x => x.DataLocacao)
                .NotNull().NotEmpty();

            RuleFor(x => x.DevolucaoPrevista)
                .NotEmpty().NotEmpty();
        }

        //public void ClienteJuridicoDevePossuirCondutorPF(Cliente cliente)
        //{
        //    if(cliente.TipoCliente == TipoClienteEnum.PessoaJuridica && cliente)
        //    {

        //    }
        //}
    }
}
