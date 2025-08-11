using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeUserManagement.Application.DTOs;

namespace BeeUserManagement.Application.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllAsync();
        Task<RoleDto> GetByIdAsync(Guid id);
        Task<RoleDto> CreateAsync(RoleDto roleDto);
        Task<bool> UpdateAsync(RoleDto roleDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
