using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabsTask.Models;

namespace TabsTask.Repositories
{
    public interface IUserManagement
    {
        public List<UserInformation> GetUserInformation();
    }
}
