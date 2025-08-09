using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeUserManagement.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Relación: un Rol tiene muchos Usuarios
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
