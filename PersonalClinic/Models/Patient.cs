using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalClinic.Models
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name="Nama")]
        public String Name { get; set; }

        [Display(Name = "Nomer Handphone")]
        public String PhoneNumber { get; set; }

        [Display(Name="Alamat")]
        public String Address { get; set; }

        [Display(Name = "KTP / ID Pengenal")]
        public String Identifier { get; set; }

        [Display(Name="Tanggal Lahir")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        public List<History> Histories { get; set; } 
    }
}
