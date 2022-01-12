using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicketingApp
{
    public abstract class Event
    {
        public abstract string Type { get; }
        public abstract string Date { get; }

        public abstract void getDescription();
        public abstract void getInfo();
        public abstract List<Ticket> offerTickets();

    }
}
