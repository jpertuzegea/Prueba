//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaApi.Models;
using Services.DTO.Response;
using Services.Interfaces;
using System.Threading.Tasks;


namespace PruebaApi.Controllers
{
    [Route("api/Utils")]
    [ApiController]
    public class UtilsController : Controller
    {
        private readonly IPositionServicesDomain IPositionServicesDomain;
        private readonly IOficeServicesDomain IOficeServicesDomain;

        public UtilsController(IPositionServicesDomain I_PositionServicesDomain, IOficeServicesDomain I_OficeServicesDomain)
        {
            this.IPositionServicesDomain = I_PositionServicesDomain;
            this.IOficeServicesDomain = I_OficeServicesDomain;
        }

        [HttpGet("SelectPosition")]
        public async Task<ActionResult<ResultDto>> SelectPosition()
        {
            return await IPositionServicesDomain.SelectPosition();
        }

        [HttpGet("SelectGrade")]
        public async Task<ActionResult<ResultDto>> SelectGrade()
        {
            return await IPositionServicesDomain.SelectPosition();
        }

        [HttpGet("SelectOfices")]
        public async Task<ActionResult<ResultDto>> SelectOfices()
        {
            return await IOficeServicesDomain.SelectOfices();
        }


    }
}
