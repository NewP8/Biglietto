
namespace WebApplication.EventHandlers;

using Biglietto.Domain.Events;
using MediatR;

public class TicketCreatoEventHandler(ILogger<TicketCreatoEventHandler> _logger) :
    INotificationHandler<TicketCreato>
{ 
    //   private readonly ILogger _logger;

    // // Using DI to inject infrastructure persistence Repositories
    // public TicketCreatoEventHandler(
    //     ILogger logger)
    // {
    //     _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    // }

    public async Task Handle(TicketCreato evento, CancellationToken token)
    {
        _logger.LogInformation($"creato ticket { evento.Id }");
    }
}