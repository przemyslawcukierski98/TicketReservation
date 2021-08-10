using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class ConcertDetails
    {
        public ConcertDetails(string concertTitle, string underTitle, string description, string imageUri)
        {
            ConcertTitle = concertTitle;
            UnderTitle = underTitle;
            Description = description;
            ImageUri = imageUri;
        }

        public string ConcertTitle { get; set; }
        public string UnderTitle { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
    }
}
