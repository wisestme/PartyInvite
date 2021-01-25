using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvite.Models;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Greet()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public ViewResult CarPurchaseForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CarPurchaseForm(CarPurchaseRequest carPurchaseRequest)
        {
            return View("ReplyUserPurchase", carPurchaseRequest);
        }

        [HttpGet]
        public ViewResult FavouriteArtistForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FavouriteArtistForm(FavouriteArtistResponse favouriteArtistResponse)
        {
            return View("ReplyUserFavouriteArtist", favouriteArtistResponse);
        }
    }
}