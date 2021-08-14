using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult OrderingTicket()
        {
            return View();
        }
    }
}
