using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class RoleService
    {
        private RoleRepository _roleRepository;
        public RoleService()
        {
            _roleRepository = new RoleRepository();
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _roleRepository.GetAllRoles();
        }

        public async Task<bool> UpdateRoleCode(Role.enRoles role,decimal roleCode)
        {
            return await _roleRepository.UpdateRoleCode(role.ToString(), roleCode);
        }
    }
}
