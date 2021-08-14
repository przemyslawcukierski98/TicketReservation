using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult OrderingTicketCarti()
        {
            ViewBag.ConcertName = "Playboy Carti w Hali Torwar";
            return View("OrderingTicket");
        }

        public IActionResult OrderingTicketCool()
        {
            ViewBag.ConcertName = "COOL FESTIVAL - Hala Stulecia we Wrocławiu!";
            return View("OrderingTicket");
        }

        public IActionResult OrderingTicketZenek()
        {
            ViewBag.ConcertName = "Zenek Martyniuk Symfonicznie";
            return View("OrderingTicket");
        }

        public IActionResult OrderingTicket()
        {
            return View();
        }
    }
}
