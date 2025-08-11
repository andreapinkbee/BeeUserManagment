using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeeUserManagement.Application.DTOs;
using System.Threading.Tasks;


namespace BeeUserManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> GetByIdAsync(Guid id);
        Task<UserDto> CreateAsync(UserDto userDto);
        Task<bool> UpdateAsync(UserDto userDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
