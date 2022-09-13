using APIWeb.Models;

namespace APIWeb.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }

        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                   new Ticket{ Id= 1, BookedFor= "Sindhu", Price=500, Qty= 200},
                   new Ticket{ Id= 11, BookedFor= "moni", Price=400, Qty= 20},
                   new Ticket{ Id= 12, BookedFor= "Shilpa", Price=300, Qty= 200},
                   new Ticket{ Id= 13, BookedFor= "nithya", Price=200, Qty= 50},
                     new Ticket{ Id= 14, BookedFor= "arusha", Price=800, Qty= 10},
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
           Ticket ticket = Tickets.FirstOrDefault(p => p.Id == id);
            return ticket;
        }
    }
}
