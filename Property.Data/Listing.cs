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
        public Listing()
        {
            this.forSale = true;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(200)]
        public string Price { get; set; }

        public string Description { get; set; }

        public bool forSale { get; set; }       
    }
}
