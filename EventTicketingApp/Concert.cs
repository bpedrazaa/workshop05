using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicketingApp
{
    class Concert : Event
    {
        private string date;
        private string band;
        public Concert(string date, string band)
        {
            this.date = date;
            this.band = band;
        }
        public override string Type => "Concert";

        public override string Date => date;

        public override void getDescription()
        {
            Console.WriteLine("This is a concert event");
        }

        public override void getInfo() {
            Console.WriteLine("{0} with the presence of {1} at {2}\n", Type, band, date);
        }

        List<Ticket> tickets = new List<Ticket>();
        public override List<Ticket> offerTickets()
        {
            tickets.Add(new Ticket(80.0, "Ultra VIP", "Between 100-200"));
            tickets.Add(new Ticket(30.0, "Normal", "Between 0-99"));
            tickets.Add(new Ticket(100.0, "Golden Pass", "Between 201-215"));

            return tickets;
        }
    }
}
