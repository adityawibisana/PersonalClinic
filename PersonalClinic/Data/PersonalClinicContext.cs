using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonalClinic.Models
{
    public class PersonalClinicContext : DbContext
    {
        public PersonalClinicContext (DbContextOptions<PersonalClinicContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalClinic.Models.Patient> Patient { get; set; }
    }
}
