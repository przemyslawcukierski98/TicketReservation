﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Controllers
{
    public class ConcertsController : Controller
    {
        public IActionResult ViewAllConcerts()
        {
            List<ConcertDetails> Details = new List<ConcertDetails>();

            ConcertDetails CartiDetails = new ConcertDetails("Playboy Carti w Hali Torwar", "od 149.99 PLN", $"Jedyny taki występ w Polsce! Playboy Carti zaprezentuje po raz pierwszy na żywo utwory z wersji Deluxe kultowego albumu \"Whole Lotta Red\"!", "https://is5-ssl.mzstatic.com/image/thumb/Features115/v4/4f/6c/cf/4f6ccf13-9927-7965-d954-3178a49f8e0c/mzl.iquhwvbg.jpg/375x375cc.webp");
            ConcertDetails CoolDetails = new ConcertDetails("COOL FESTIVAL - Hala Stulecia, Wrocław", "od 299.99 PLN", "Arca, Bjork, Tyler the Creator, Amnesia Scanner, IC3PEAK, tylko w Hali Stulecia", "https://muno.pl/wp-content/uploads/2020/05/Arca-850x570.jpg");
            ConcertDetails ZenekDetails = new ConcertDetails("Zenek Martyniuk Symfonicznie", "od 99.99 PLN", "Największe hity króla disco polo w wykonaniu Narodowej Orkiestry Symfonicznej Polskiego Radia. Jedyne takie wydarzenie w stolicy Podkarpacia!", "https://i.iplsc.com/zenek-martyniuk/0009PL2T6I1M5SJB-C122-F4.jpg");

            Details.Add(CartiDetails);
            Details.Add(CoolDetails);
            Details.Add(ZenekDetails);

            ViewBag.details = Details;
            return View();
        }

        public IActionResult ZenekConcert()
        {
            PageConcertObject zenekConcertObject = new PageConcertObject();
            zenekConcertObject.Header = "Zenek Martyniuk Symfonicznie";
            zenekConcertObject.HeaderDescription = "Hala Podpromie, Rzeszów, 23/12/2021, 21:00";
            zenekConcertObject.MainImageUri = "https://ocdn.eu/pulscms-transforms/1/h25k9kpTURBXy85YzA4MGJjNmJkZDk4OGI4NTg5YjQ0ODBmMTdlNTMxNy5qcGeSlQMANs0KIM0FspMFzQNIzQH6gqEwBaExAQ";
            zenekConcertObject.ConcertDescription = "Narodowa Orkiestra Symfoniczna Polskiego Radia wykona specjalnie przygotowane aranżacje największych hitów barda muzyki disco-polo. Zenek Martyniuk - tej postaci nikomu przedstawiać nie trzeba, a twórczości króla polskiej muzyki tanecznej postarają się sprostać instrumentaliści z NOSPR. Zapraszamy serdecznie!";

            ViewBag.zenekConcert = zenekConcertObject;
            return View();
        }

        public IActionResult CartiConcert()
        {
            PageConcertObject cartiConcertObject = new PageConcertObject();
            cartiConcertObject.Header = "Playboy Carti w Hali Torwar";
            cartiConcertObject.HeaderDescription = "Hala Torwar, Warszawa, 03/07/2021, 19:30";
            cartiConcertObject.MainImageUri = "https://img.discogs.com/xx-TjXD-s5ZzcrGqNka830DN-fk=/600x846/smart/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/A-4637951-1510976555-3557.jpeg.jpg";
            cartiConcertObject.ConcertDescription = "Jeden z najwybitniejszych raperów młodego pokolenia - Playboy Carti wraz z nowym albumem \"Whole Lotta Red\" po raz pierwszy w Polsce! Gotowi na muzyczne wydarzenie roku?";

            ViewBag.cartiConcert = cartiConcertObject;
            return View();
        }

        public IActionResult CoolConcert()
        {
            PageConcertObject coolConcertObject = new PageConcertObject();
            coolConcertObject.Header = "COOL FESTIVAL - Hala Stulecia we Wrocławiu!";
            coolConcertObject.HeaderDescription = "Hala Stulecia, Wrocław, 15/09/2021, 17:00";
            coolConcertObject.MainImageUri = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Arca_Sonar_1.jpg/1200px-Arca_Sonar_1.jpg";
            coolConcertObject.ConcertDescription = "Arca, Bjork, Tyler the Creator, Amnesia Scanner, IC3PEAK, tylko w Hali Stulecia, 15 września 2021 r.!";

            ViewBag.coolConcert = coolConcertObject;
            return View();
        }
    }
}
