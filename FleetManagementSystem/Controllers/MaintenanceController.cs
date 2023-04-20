using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceManager maintenanceManager;
        public MaintenanceController(IMaintenanceManager maintenanceManager)
        {
            this.maintenanceManager = maintenanceManager;
        }

        [HttpGet]
        public List<Maintenance> Get()
        {
            return maintenanceManager.GetMaintenances();
        }

        [HttpPost]

        public bool Post([FromForm] Maintenance maintenance)
        {
            return maintenanceManager.UpdateMaintenance(maintenance);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return maintenanceManager.DeleteMaintenance(id);
        }

    }


}
