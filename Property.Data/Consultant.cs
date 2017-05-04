using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data
{
    public class Consultant
    {
        //attributes from normalisation   
        public string ConsultantID { get; set; }
        public string ConsultantName { get; set; }
         //link to assigned property
        public virtual Listing AssignedListing { get; set; }
    }
}
