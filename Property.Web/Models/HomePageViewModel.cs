using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Property.Web.Models
{
    public class HomePageViewModel
    {

        public IEnumerable<ListingViewModel> CurrentListings{ get; set; }

    }
}