using Biglietto.Domain.Aggregates;
using Biglietto.Infrastructure;
using WebApplication.Commands;
using Microsoft.EntityFrameworkCore;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BigliettoContext>(options =>
    options.UseSqlite($"Data Source=/home/paolo/Work/Biglietto/LocalDb.db"));

// Add services to the container.
builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(typeof(Ticket).Assembly, typeof(CreaTicket).Assembly);
        });

builder.Services.AddTransient<ITicketRepository,TicketRepository>();
// builder.Services.AddLogging();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
