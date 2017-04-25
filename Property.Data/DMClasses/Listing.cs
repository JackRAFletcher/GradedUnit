using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data.DMClasses
{
    [Table("Listing")]
    public class Listing
    {
        //property attributes as defined in my normalisation document (3NF)

        [Key]
        public string ListingNo { get; set; }

        public string StreetAddress { get; set; }

        public string Town { get; set; }


    }
}
