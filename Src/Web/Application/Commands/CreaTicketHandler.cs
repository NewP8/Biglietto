namespace WebApplication.Commands;

using Biglietto.Domain.Aggregates;
using Biglietto.Domain.Events;
using MediatR;
// using Biglietto

/// <summary>
/// Comando di creazione nuovo ticket
/// </summary>
public class CreaTicketHandler
    : IRequestHandler<CreaTicket, int>
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMediator _mediator;
    private readonly ILogger<CreaTicketHandler> _logger;

    // Using DI to inject infrastructure persistence Repositories
    public CreaTicketHandler(IMediator mediator,
        ITicketRepository ticketRepository,
        ILogger<CreaTicketHandler> logger)
    {
        _ticketRepository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<int> Handle(CreaTicket message, CancellationToken cancellationToken) {
        var ticket = new Ticket{
            Segnalatore = message.Segnalatore,
            Segnalazione = message.Segnalazione,
        };

        _ticketRepository.Add(ticket);
        await _ticketRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

        // dopo creazione notifica evento globale
        // await _eventBus.PublishAsync(logEvt.IntegrationEvent);
        await _mediator.Publish(new TicketCreato(ticket.Id));

        return ticket.Id;
    }
}