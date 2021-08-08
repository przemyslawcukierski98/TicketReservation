using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Concert
    {
        public Artist ArtistObj { get; set; }
        public DateTime Date { get; set; }
        public Address ConcertAddress { get; set; }
        public string Description { get; set; }
        public int NumberOfTickets { get; set; }
    }
}
