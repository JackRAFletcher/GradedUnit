using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data.DMClasses
{
    public class Viewing
    {
        //attributes defined in normalisation
        public string AppointmentID { get; set; }
        public int PropertyNo { get; set; }
        public DateTime ViewingDate { get; set; }

        //link to the listing the viewing is of
        public virtual Listing Listing { get; set; }
        //link to the viewer attending the viewing
        public virtual Customer Viewer { get; set; }


    }
}
