using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZadanieDomowe2.Models;

namespace ZadanieDomowe2.Controllers
{
    public class HomeController : Controller
    {
        List<Track> tracks;

        //private readonly ILogger<HomeController> _logger;

        /* public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }
        */

        public HomeController()
        {

            tracks = new List<Track>();
            tracks.Add(new Track(1, "Zwykły tor na parterze bez dodatkowych świateł", 40, 4));
            tracks.Add(new Track(2, "Zwykły tor na parterze bez dodatkowych świateł", 60, 6));
            tracks.Add(new Track(3, "Tor z pomocami w grze dla dzieci", 50, 4));
            tracks.Add(new Track(4, "Tor na piętrze z dodatkowymi światłami, które urozmaicaja rozgrywke", 60, 4));
            tracks.Add(new Track(5, "Tor na piętrze z dodatkowymi światłami, które urozmaicaja rozgrywke", 90, 6));
            tracks.Add(new Track(6, "Prywatny tor w osobnym pomieszczeniu", 150, 6));


        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Lista Wszystkich Torów 
        /// </summary>
        /// <returns></returns>
        public IActionResult AllTracks()
        {
            return View(tracks);
        }
        /// <summary>
        /// Wybór toru 
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public IActionResult TrackHours(int Number)
        {
            var track = tracks.FirstOrDefault(x => x.Number == Number);
            return View(track);
        }
        /// <summary>
        /// Rezerwacja toru
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public IActionResult Reservation(int Number)
        {
            var track = tracks.FirstOrDefault(x => x.Number == Number);
            ViewBag.track = track;
            return View();
        }
        /// <summary>
        /// Metoda posta do rezerwacji toru
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reservation([Bind("TrackNumber,Name,LastName,Phone")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                reservation.ReservationDate = DateTime.Now;
                var track = tracks.FirstOrDefault(x => x.Number == reservation.TrackNumber);
                ViewBag.reservedTrack = track;
                return View("PlacedReservation", reservation);
            }
            else
            {
                var track = tracks.FirstOrDefault(x => x.Number == reservation.TrackNumber);
                ViewBag.track = track;
                return View(reservation);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Wyswietlenie godzin otwarcia
        /// </summary>
        /// <returns></returns>
        public IActionResult OpeningHours()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
