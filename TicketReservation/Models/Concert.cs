using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Concert
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public List<Artist> ArtistLists { get; set; }
        public DateTime Date { get; set; }
        public Address ConcertAddress { get; set; }
        public string Description { get; set; }
        public int NumberOfTickets { get; set; }
    }
}
