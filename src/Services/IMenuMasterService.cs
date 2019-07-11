using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoleBasedMenu.Model;

namespace RoleBasedMenu.Services
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();

    }
}
