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
    public class MaintenanceManager : IMaintenanceManager
    {
        private readonly DatabaseContext dbContext;
        public MaintenanceManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Maintenance> GetMaintenances()
        {
            return dbContext.Maintenance.ToList();
        }
        public bool UpdateMaintenance(Maintenance maintenance)
        {

            bool MaintenanceExists = dbContext.Maintenance.Any(b => b.MaintenanceId == maintenance.MaintenanceId);

            if (MaintenanceExists)
            {
                dbContext.Maintenance.Update(maintenance);
            }
            else
            {
                dbContext.Maintenance.Add(maintenance);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteMaintenance(Guid id)
        {
            bool MaintenanceExists = dbContext.Maintenance.Any(b => b.MaintenanceId == id);
            if (MaintenanceExists)
            {
                dbContext.Maintenance.Remove(new Maintenance { MaintenanceId = id });
                return true;
            }
            return false;
        }
    }
}
