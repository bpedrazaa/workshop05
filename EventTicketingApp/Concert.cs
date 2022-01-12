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
            Console.WriteLine("{0} with the presence of {1} at {2}", Type, band, date);
        }

    }
}
