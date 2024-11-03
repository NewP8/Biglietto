using MediatR;

namespace Biglietto.Domain.Events;

/// <summary>
/// Evento Ticket creato
/// </summary>
public class TicketCreato : INotification
{
    public int Id { get; set; }

    public TicketCreato(int id)
    {
        Id = id;
    }
}