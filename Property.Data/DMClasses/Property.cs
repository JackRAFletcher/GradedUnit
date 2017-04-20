using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Data
{
    [Table("Property")]
    class Property
    {
        //property attributes as defined in my normalisation document (3NF)

        [Key]
        public string PropertyNo { get; set; }

        public string StreetAddress { get; set; }

        public string Town { get; set; }


    }
}
