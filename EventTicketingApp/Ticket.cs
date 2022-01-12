using System;
using System.Collections.Generic;
using System.Text;

namespace EventTicketingApp
{
    public class Ticket
    {
        private double price;
        private string type;
        private string place;

        public Ticket(double p, string t, string pl) {
            this.price = p;
            this.type = t;
            this.place = pl;
        }

        public void getTicketInfo(){
            Console.Write("The ticket of type {0} costs {1} Bolivians, the place of your chair is {2}\n", type, price, place);
        }
    }
}
