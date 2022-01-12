using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicketingApp
{
    public class Match : Event
    {
        private string date;
        private string team01, team02;
        public Match(string date, string t1, string t2)
        {
            this.date = date;
            this.team01 = t1;
            this.team02 = t2;
        }
        public override string Type => "Match";

        public override string Date => date;

        public override void getDescription()
        {
            Console.WriteLine("This is a match event");
        }

        public override void getInfo()
        {
            Console.WriteLine("{0} that will confront {1} vs {2} at {3}\n", Type, team01, team02, date);
        }

        List<Ticket> tickets = new List<Ticket>();

        public override List<Ticket> offerTickets()
        {
            tickets.Add(new Ticket(40.0, "VIP", "Between 150-200"));
            tickets.Add(new Ticket(20.0, "Normal", "Between 0-100"));

            return tickets;
        }




    }
}
