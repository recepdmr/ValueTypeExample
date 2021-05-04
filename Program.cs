using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using ValueTypeExample.DataAccess;
using ValueTypeExample.Entities;

namespace ValueTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(x =>
            x.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=password;"));

            var provider = services.BuildServiceProvider();
            var dbContext = provider.GetRequiredService<ApplicationDbContext>();

            var ticket = new Ticket
            {
                CreatedDate = DateTimeOffset.UtcNow,
                Id = Guid.NewGuid(),
                PnrNo = "PDS323",
                PnrDetail = new PnrDetail
                {
                    ArrivalCode = "IST",
                    ArrivalName = "İstanbul Hava Limani",
                    DepartureCode = "ASR",
                    DepartureName = "Kayseri Hava Limani"
                }
            };

            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();

            var tickets = dbContext.Tickets.ToList();
        }
    }
}
