using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        public Guid ChauffeurId { get; set; }
        public string? ChauffeurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Cnic { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LicenceNumber { get; set; }
        public Guid AssignedCarId { get; set; }
        public bool? Availablity { get; set; }

        // Add Relationships !
        // A Chauffeur can be assigned One Vehicle at a time
        public Vehicle? Vehicle {get;set;}
    }
}
