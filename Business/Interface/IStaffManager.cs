using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IStaffManager
    {
        public List<IStaffManager> GetStaffList();
        public bool UpdateStaff(IStaffManager staff);

        public bool DeleteStaff(Guid id);
    }
}
