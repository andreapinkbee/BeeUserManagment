using BeeUserManagement.Application.DTOs;
using BeeUserManagement.Application.Interfaces;
using BeeUserManagement.Application.Interfaces.Security;
using BeeUserManagement.Domain.Entities;
using BeeUserManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace BeeUserManagement.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;


        public LoginService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<LoginResponseDto?> AuthenticateAsync(LoginRequestDto request)
        {
            // Buscar usuario por email
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null) return null;

            // Validar contraseña (por ahora simple, luego podemos meter hash + salt)
            if (user.PasswordHash != request.Password) return null;

            // Generar token JWT
            var token = _jwtTokenGenerator.GenerateToken(user);

            // Construir respuesta
            return new LoginResponseDto
            { 
                FullName = $"{user.FullName}",
                Role = user.Role?.Name ?? string.Empty,
                Token = token
            };
        }
    }
}