using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabsTask.ApplicationContext;
using TabsTask.Models;

namespace TabsTask.Repositories
{
    public class UserManagement : IUserManagement
    {
        private readonly ApplicationDbContext _context;
        public UserManagement(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<UserInformation> GetUserInformation()
        {
            
            return _context.UserInformation.ToList();
        }
    }
}
