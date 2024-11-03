namespace Biglietto.Domain.Aggregates;

/// <exclude />
public interface ITicketRepository : IRepository<Ticket>
{
    Ticket Add(Ticket ticket);

    void Update(Ticket ticket);

    Task<Ticket> GetAsync(int ticketId);
}