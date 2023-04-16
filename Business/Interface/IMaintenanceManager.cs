using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IMaintenanceManager
    {
        public List<Maintenance> GetMaintenances();
        public bool UpdateMaintenance(Maintenance maintenance);
        public bool DeleteMaintenance(Guid id);
    }
}
