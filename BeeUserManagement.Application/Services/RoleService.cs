
using BeeUserManagement.Application.DTOs;
using BeeUserManagement.Application.Interfaces;
using BeeUserManagement.Infraestructure.Data;
using BeeUserManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeUserManagement.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly BeeUserManagementDbContext _context;

        public RoleService(BeeUserManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleDto>> GetAllAsync()
        {
            return await _context.Roles
                .Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .ToListAsync();
        }

        public async Task<RoleDto> GetByIdAsync(Guid id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role == null) return null;

            return new RoleDto
            {
                Id = role.Id,
                Name = role.Name
            };
        }

        public async Task<RoleDto> CreateAsync(RoleDto roleDto)
        {
            var role = new Role   
            {
                Id = Guid.NewGuid(),
                Name = roleDto.Name
            };

            _context.Roles.Add(role);
            await _context.SaveChangesAsync();

            roleDto.Id = role.Id;
            return roleDto;
        }

        public async Task<bool> UpdateAsync(RoleDto roleDto)
        {
            var role = await _context.Roles.FindAsync(roleDto.Id);
            if (role == null) return false;

            role.Name = roleDto.Name;
            _context.Roles.Update(role);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role == null) return false;

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
