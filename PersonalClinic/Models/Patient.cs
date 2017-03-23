using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalClinic.Models
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String Identifier { get; set; }
        public List<History> Histories { get; set; } 
    }
}
