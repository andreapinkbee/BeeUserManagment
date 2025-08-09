using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BeeUserManagement.Domain.Entities
{
  
        public class User
        {
            public Guid Id { get; set; }
            public string FullName { get; set; } = null!;
            public string Email { get; set; } = null!;
            public string PasswordHash { get; set; } = null!;
            public Guid RoleId { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }

            // Relación: un Usuario tiene un Rol
            public Role Role { get; set; } = null!;
        }

}
