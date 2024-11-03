using WebApplication.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

public class TicketController : Controller
{
    private readonly ILogger<TicketController> _logger;

    private readonly IMediator _mediator;

    public TicketController(ILogger<TicketController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult CreaNuovoTicket()
    {
        _mediator.Send(new CreaTicket{
            Segnalatore = "Gigi",
            Segnalazione = "Non va niente"
        });
        _logger.LogInformation("log creato");
        return Ok();
    }
}
