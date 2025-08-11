using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeUserManagement.Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }      // Igual que en la entidad
        public string FullName { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } // Para mostrar el nombre del rol en consultas
    }
}
