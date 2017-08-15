using Property.Data;
using System.ComponentModel.DataAnnotations;

namespace Property.Web.Models
{
    public class ListingInputModel
    {
        [Required(ErrorMessage = "Property Address is required.")]
        [StringLength(200, ErrorMessage = "The {0} must be between {2} and {1} characters long.",
           MinimumLength = 1)]
        [Display(Name = "Property Address *")]
        public string StreetAddress { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }


        public bool ForSale { get; set; }

        public static ListingInputModel CreateFromListing(Listing l)
        {
            return new ListingInputModel()
            {
                StreetAddress = l.Address,
                Price = l.Price,
                Description = l.Description,
                ForSale = l.forSale
            };
        }
    }
}