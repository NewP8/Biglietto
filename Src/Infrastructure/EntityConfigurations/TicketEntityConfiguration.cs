// TIcket Entity Type configuration
using Biglietto.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biglietto.Infrastructure;

class TicketEntityConfiguration
    : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> ticketConfiguration)
    {
        ticketConfiguration.ToTable("ticket");
        ticketConfiguration.Ignore(b => b.DomainEvents);
        ticketConfiguration.Property(b => b.Id);
        ticketConfiguration.Property(b => b.Segnalatore);
        ticketConfiguration.Property(b => b.Segnalazione);
        ticketConfiguration.Property(b => b.Stato);
        ticketConfiguration.Property(b => b.DataApertura);
        ticketConfiguration.Property(b => b.Risposta);
    }
}