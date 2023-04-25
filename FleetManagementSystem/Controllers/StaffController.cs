using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffManager staffManager;
        public StaffController(IStaffManager staffManager)
        {
            this.staffManager = staffManager;
        }

        [HttpGet]
        public List<Staff> Get()
        {
            return staffManager.GetStaffList();
        }

        [HttpPost]

        public bool Post([FromForm] Staff staff)
        {
            return staffManager.UpdateStaff(staff);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return staffManager.DeleteStaff(id);
        }

    }


}
