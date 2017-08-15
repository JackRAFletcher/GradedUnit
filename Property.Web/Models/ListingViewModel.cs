using Property.Data;
using System;
using System.Linq.Expressions;

namespace Property.Web.Models
{
    public class ListingViewModel
    {

       // public string ListingNo { get; set; }
        public string StreetAddress { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public bool ForSale { get; set; }

        public static Expression<Func<Listing, ListingViewModel>> ViewModel
        {
            get
            {
                return l => new ListingViewModel()
                {
                    StreetAddress = l.Address, ForSale = l.forSale, Description = l.Description, Price = l.Price
                };
            }
        }
    }
}