namespace Biglietto.Domain;

/// <exclude />
public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}