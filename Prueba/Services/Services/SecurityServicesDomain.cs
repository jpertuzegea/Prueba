//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.DTO;
using Services.DTO.Request;
using Services.DTO.Response;
using Services.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SecurityServicesDomain : ISecurityServicesDomain
    {

        private readonly IConfiguration configuration;

        public SecurityServicesDomain(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }
         

        public async Task<ResultDto> LogIn(LoginDto LoginDto)
        {
            ResultDto ResultDto = new ResultDto();

            if (LoginDto.UserName == null || LoginDto.Password == null)
            {// si el objeto es diferente de nulo

                ResultDto.HasError = false;
                ResultDto.Data = string.Empty;
                ResultDto.Messages = "User y Clave son requeridos";
                return ResultDto;
            }

            try
            {
                LoginDto.IsLogued = true;
                LoginDto.Token = ConstruirToken();
                LoginDto.Password = "";

                ResultDto.HasError = false;
                ResultDto.Data = LoginDto;


                return ResultDto;
            }
            catch (Exception Error)
            {
                ResultDto.HasError = true;
                ResultDto.Messages = $"Error Técnico Al Iniciar Sesion: {Error.Message}";
                ResultDto.Data = Error;

                return ResultDto;
            }
        }

        private string ConstruirToken()
        {
            string UserRol = "Administrador";

            var Claims = new[] { 
                new Claim(JwtRegisteredClaimNames.UniqueName, "Jpertuzegea@hotmail.com"),

                new Claim("UserId", "1"),
                new Claim("DocumentNumber", "123456789"),
                new Claim("UserEmail", "Jpertuzegea@hotmail.com"),
                new Claim("UserName", "Jpertuzegea"),
                new Claim("UserRol",  UserRol),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // Genera un GUID por cada token
            };

            JWTAuthentication JWTAuthenticationSection = configuration.GetSection("JWTAuthentication").Get<JWTAuthentication>();

            SymmetricSecurityKey Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTAuthenticationSection.Secret));
            var Credenciales = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

            DateTime Expiration = DateTime.Now.AddMinutes(JWTAuthenticationSection.ExpirationInMinutes);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: "",
               audience: "",
               claims: Claims,
               expires: Expiration,
               signingCredentials: Credenciales,
               notBefore: DateTime.Now.AddMilliseconds(3000)
               );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        

    }
}
