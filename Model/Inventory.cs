using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inventory
    {
        public Guid PartId { get; set; }
        public string? PartName { get; set; }
        public string? CarType { get; set; }

        public int Price { get; set; }

        public string? Manufacturer { get; set; }
        public string? Comments { get; set; }
    }
}
