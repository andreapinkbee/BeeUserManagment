using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeUserManagement.Application.DTOs;
using System.Threading.Tasks;

namespace BeeUserManagement.Application.Interfaces
{
    
        public interface ILoginService
        {
            Task<LoginResponseDto?> AuthenticateAsync(LoginRequestDto request);
        }
    
}
