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
    public class InventoryManager : IInventoryManager
    {
        private readonly DatabaseContext dbContext;
        public InventoryManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Inventory> GetInventories()
        {
            return dbContext.Inventory.ToList();
        }
        public bool UpdateInventory(Inventory inventory)
        {

            bool InventoryExists = dbContext.Inventory.Any(b => b.PartId == inventory.PartId);

            if (InventoryExists)
            {
                dbContext.Inventory.Update(inventory);
            }
            else
            {
                dbContext.Inventory.Add(inventory);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteInventory(Guid id)
        {
            bool InventoryExists = dbContext.Inventory.Any(b => b.PartId == id);
            if (InventoryExists)
            {
                dbContext.Inventory.Remove(new Inventory { PartId = id });
                return true;
            }
            return false;
        }
    }
}
