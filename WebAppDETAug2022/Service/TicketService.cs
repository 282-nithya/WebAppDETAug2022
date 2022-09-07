using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        private static Ticket ticket;

        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                   new Ticket{ Id= 1, Name = "Movie1",Price=5000},
                   new Ticket{ Id= 2, Name = "Movie2",Price=4000},
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket Ticket)
        {
            Ticket.Id = nextId++;
            Tickets.Add(Ticket);
        }

        public static void Delete(int id)
        {
            var Ticket = Get(id);
            if (Ticket is null)
                return;

            Tickets.Remove(Ticket);
        }

        public static void Update(Ticket Ticket)
        {
            var index = Tickets.FindIndex(t => t.Id == Ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
