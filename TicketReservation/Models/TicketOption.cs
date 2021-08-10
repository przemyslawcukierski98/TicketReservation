using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class TicketOption
    {
        public string TicketHeader { get; set; }
        public List<string> TicketDetails { get; set; }
        public string TicketPrice { get; set; }
    }
}
