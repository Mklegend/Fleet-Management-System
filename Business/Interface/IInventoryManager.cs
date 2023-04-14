using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IInventoryManager
    {
        public List<IInventoryManager> GetInventories();
        public bool UpdateInventory(IInventoryManager inventory);
        public bool DeleteInventory(Guid id);
    }
}
