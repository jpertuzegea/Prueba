//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.DTO.Request;
using Services.DTO.Response;
using Services.Interfaces;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [Route("api/Security")]
    [ApiController] 
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SecurityController : Controller
    {
        private readonly ISecurityServicesDomain ISecurityServicesDomain;

        public SecurityController(ISecurityServicesDomain I_SecurityServicesDomain)
        {
            this.ISecurityServicesDomain = I_SecurityServicesDomain;
        }


        [HttpPost("LogIn")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultDto>> LogIn([FromBody] LoginDto LoginDto)
        {
            return await ISecurityServicesDomain.LogIn(LoginDto);
        }


    }
}
