using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleManager vehicleManager;
        public VehicleController(IVehicleManager vehicleManager)
        {
            this.vehicleManager = vehicleManager;
        }

        [HttpGet]
        public List<Vehicle> Get()
        {
            return vehicleManager.GetVehicles();
        }

        [HttpPost]

        public bool Post([FromBody] Vehicle vehicle)
        {
            return vehicleManager.UpdateVehicle(vehicle);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return vehicleManager.DeleteVehicle(id);
        }

    }


}
