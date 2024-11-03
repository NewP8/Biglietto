namespace WebApplication.Commands;

using MediatR;

/// <summary>
/// Richiesta di creazione nuovo ticket
/// </summary>
public class CreaTicket: IRequest<int>
{
    /// <summary>
    /// nome del segnalatore
    /// </summary>
    public string Segnalatore { get;set; }
    public string Segnalazione { get;set; }
}