using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Maintenance
    {
        public Guid MaintenanceId { get; set; }
        public Guid VehicleId { get; set; }
        public string? ServiceType { get; set; }
        public int Charges { get; set; }
        public string? WorkshopName { get; set; }
        public string? Comments { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Add Relationships
        // A Maintenance can be assocaited with only One Vehicle
        public Vehicle? Vehicle {get;set;}
    }
}
