using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data.DMClasses
{
    [Table("Viewing")]
    class Viewing
    {
        [Key]
        public string AppointmentID { get; set; }
        [ForeignKey("Property")]
        public int PropertyNo { get; set; }
        public DateTime ViewingDate { get; set; }



    }
}
