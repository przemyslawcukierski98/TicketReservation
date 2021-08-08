using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketReservation.Controllers
{
    public class ConcertsController : Controller
    {
        public IActionResult ViewAllConcerts()
        {
            return View();
        }

        public IActionResult ZenekConcert()
        {
            return View();
        }
    }
}
