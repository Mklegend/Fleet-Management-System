using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryManager inventoryManager;
        public InventoryController(IInventoryManager inventoryManager)
        {
            this.inventoryManager = inventoryManager;
        }

        [HttpGet]
        public List<Inventory> Get()
        {
            return inventoryManager.GetInventories();
        }

        [HttpPost]

        public bool Post([FromBody] Inventory inventory)
        {
            return inventoryManager.UpdateInventory(inventory);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return inventoryManager.DeleteInventory(id);
        }

    }


}
