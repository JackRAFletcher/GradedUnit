using Property.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            var CurrentListings = this.db.Listings.Where(e => e.forSale).Select(e => new ListingViewModel()
            {
                StreetAddress = e.Address, Description = e.Description, Price = e.Price, ForSale = e.forSale
            });

            var currentListings = CurrentListings.Where(e => e.ForSale);
            return View(new HomePageViewModel() {
                CurrentListings = currentListings
            });
        }
    }
}

       