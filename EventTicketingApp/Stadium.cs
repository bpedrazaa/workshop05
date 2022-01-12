using System;
using System.Collections.Generic;

namespace EventTicketingApp
{
    class Stadium
    {
        static void Main(string[] args)
        {
            // Concert event
            Event radioheadConcert = new Concert("12-08-2022", "Radiohead");
            radioheadConcert.getDescription();
            radioheadConcert.getInfo();

            
            List<Ticket> tickets = radioheadConcert.offerTickets();
            Console.WriteLine("Available Tickets for the {0}", radioheadConcert.Type);
            foreach (var t in tickets)
            {
                t.getTicketInfo();
            }
            Console.WriteLine("\n\n");

            // Match event
            Event elClasico = new Match("10-09-2022", "Real Madrid", "Barcelona");
            elClasico.getDescription();
            elClasico.getInfo();

            tickets = elClasico.offerTickets();
            Console.WriteLine("Available Tickets for the {0}", elClasico.Type);
            foreach (var t in tickets)
            {
                t.getTicketInfo();
            }
        }
    }
}
