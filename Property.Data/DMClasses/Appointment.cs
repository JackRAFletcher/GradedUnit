using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data
{
    [Table("Appointment")]
    public class Appointment
    {
        //appointment attributes as defined in my normalisation document
        [Key]
        public string AppointmentID { get; set; }
        [ForeignKey("Property")]
        public string CustomerID { get; set; }
        [ForeignKey("Consultant")]
        public string ConsultantID { get; set; }
        public DateTime DateOfConsultation { get; set; }
    }
}
