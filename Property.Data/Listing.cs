using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data
{
   
    public class Listing
    {
        //property attributes as defined in my normalisation document (3NF)
        public string ListingNo { get; set; }
        public string StreetAddress { get; set; }
        public string Town { get; set; }

        //additional attributes
        public int Price { get; set; }
        public int NumberOfBedrooms { get; set; }
        public string TypeOfProperty { get; set; }

        //link to consultant
        public virtual Consultant AssignedConsultant { get; set; }
    }
}
