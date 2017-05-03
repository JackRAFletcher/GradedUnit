using Property.Data.DMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Property.Web.Models
{
    public class ListingViewModel
    {
        public string ListingNo { get; set; }
        public string StreetAddress { get; set; }
        public string Town { get; set; }

        public static Expression<Func<Listing, ListingViewModel>> ViewModel
        {
            get
            {
                return l => new ListingViewModel()
                {
                    ListingNo = l.ListingNo,
                    StreetAddress = l.StreetAddress,
                    Town = l.Town                    
                };
            }
        }
    }
}