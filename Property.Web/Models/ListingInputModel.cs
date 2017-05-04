using Property.Data;
using Property.Data.DMClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Property.Web.Models
{
    public class ListingInputModel
    {
        [Required(ErrorMessage = "Property Address is required.")]
        [StringLength(200, ErrorMessage = "The {0} must be between {2} and {1} characters long.",
           MinimumLength = 1)]
        [Display(Name = "Property Address *")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Town is required.")]
        [StringLength (50, ErrorMessage = "The {0} must be between {2} and {1} characters long.",
           MinimumLength = 1)]
        public string Town { get; set; }

        public static ListingInputModel CreateFromListing(Listing l)
        {
            return new ListingInputModel()
            {
                StreetAddress = l.StreetAddress,
                Town = l.Town
            };
        }
    }
}