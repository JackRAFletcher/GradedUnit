using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data.DMClasses
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileTelephone { get; set; }
        public string HomeTelephone { get; set; }

    }
}
