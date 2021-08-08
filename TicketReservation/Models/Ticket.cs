using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class Ticket
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Concert ConcertObj { get; set; }
        public Address AddressObj { get; set; }
        public double TicketPrice { get; set; }
        public string PhoneNumber { get; set; }
        public string TicketCode { get; set; }
    }
}
