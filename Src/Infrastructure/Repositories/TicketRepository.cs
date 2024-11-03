namespace Biglietto.Infrastructure;

using Biglietto.Domain;
using Biglietto.Domain.Aggregates;

public class TicketRepository
    : ITicketRepository
{
    private readonly BigliettoContext _context;

    public IUnitOfWork UnitOfWork => _context;

    public TicketRepository(BigliettoContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Ticket Add(Ticket ticket)
    {
        return _context.Tickets.Add(ticket).Entity;

    }

    public async Task<Ticket> GetAsync(int ticketId)
    {
        var ticket = await _context.Tickets.FindAsync(ticketId);
        return ticket;
    }

    public void Update(Ticket ticket)
    {
        var newT = _context.Tickets.Find(ticket.Id);
        if (newT != null){
          newT = ticket;
        }
    }
}