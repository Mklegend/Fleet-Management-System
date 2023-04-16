using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    internal interface IVehicleManager
    {
        public List<Vehicle> GetVehicles();
        public bool UpdateVehicle(Vehicle vehicle);
        public bool DeleteVehicle(Guid id);
    }
}
