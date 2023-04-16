using Business.Interface;
using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public class VehicleManager : IVehicleManager
    {
        private readonly DatabaseContext dbContext;
        public VehicleManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Vehicle> GetVehicles()
        {
            return dbContext.Vehicle.ToList();
        }
        public bool UpdateVehicle(Vehicle vehicle)
        {

            bool VehicleExists = dbContext.Vehicle.Any(b => b.VehicleId == vehicle.VehicleId);

            if (VehicleExists)
            {
                dbContext.Vehicle.Update(vehicle);
            }
            else
            {
                dbContext.Vehicle.Add(vehicle);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteVehicle(Guid id)
        {
            bool VehicleExists = dbContext.Vehicle.Any(b => b.VehicleId == id);
            if (VehicleExists)
            {
                dbContext.Vehicle.Remove(new Vehicle { VehicleId = id });
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
