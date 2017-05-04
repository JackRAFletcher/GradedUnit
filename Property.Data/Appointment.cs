using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data
{
    public class Appointment
    {
        //appointment attributes as defined in my normalisation document
        public string AppointmentID { get; set; }
        public DateTime DateOfConsultation { get; set; }

        //additional attributes


    }
}
