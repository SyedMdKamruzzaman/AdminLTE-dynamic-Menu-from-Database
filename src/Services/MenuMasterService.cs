using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoleBasedMenu.Data;
using RoleBasedMenu.Model;

namespace RoleBasedMenu.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly ApplicationDbContext dbContext;

        public MenuMasterService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return dbContext.MenuMaster.AsEnumerable();
        }
                
    }
}
