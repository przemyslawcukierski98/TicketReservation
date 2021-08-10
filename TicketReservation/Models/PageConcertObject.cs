using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Models
{
    public class PageConcertObject
    {
        public string Header { get; set; }
        public string HeaderDescription { get; set; }
        public string MainImageUri { get; set; }
        public string ConcertDescription { get; set; }
        public List<ArtistPom> ArtistPomList { get; set; }
        public List<TicketOption> TicketOptions { get; set; }
    }
}
