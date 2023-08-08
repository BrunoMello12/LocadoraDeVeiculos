using SequentialGuid;

namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public EntidadeBase()
        {
            Id = SequentialGuidGenerator.Instance.NewGuid();
        }

        public Guid Id { get; set; }

        public abstract void Atualizar(T registro);
    }
}
