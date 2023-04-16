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
    public class StaffManager : IStaffManager
    {
        private readonly DatabaseContext dbContext;
        public StaffManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Staff> GetStaffList()
        {
            return dbContext.Staff.ToList();
        }
        public bool UpdateStaff(Staff staff)
        {

            bool StaffExists = dbContext.Staff.Any(b => b.ChauffeurId == staff.ChauffeurId);

            if (StaffExists)
            {
                dbContext.Staff.Update(staff);
            }
            else
            {
                dbContext.Staff.Add(staff);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteStaff(Guid id)
        {
            bool StaffExists = dbContext.Staff.Any(b => b.ChauffeurId == id);
            if (StaffExists)
            {
                dbContext.Staff.Remove(new Staff { ChauffeurId = id });
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
