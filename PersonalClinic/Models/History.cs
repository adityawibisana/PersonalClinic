using System;

namespace PersonalClinic.Models
{
    public class History
    { 
        public Guid Id { get; set; } 
        public int PatientId { get; set; }
        public DateTime CreationDate { get; set; }
        public String Note { get; set; }
    }
}