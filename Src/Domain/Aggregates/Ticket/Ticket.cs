namespace Biglietto.Domain.Aggregates;

/// <summary>
/// Aggregato Ticket
/// </summary>
public class Ticket: Entity, IAggregateRoot
{
    public DateTime DataApertura { get; set; }

    /// <summary>
    /// Nome del soggetto segnalatore
    /// </summary>
    public string Segnalatore { get; set; }
    public string Segnalazione { get; set; }
    public string Risposta { get; set; }
    public StatoTicket Stato { get; set; }
}

public enum StatoTicket
{
    Creato,
    InLavorazione,
    Chiuso
}