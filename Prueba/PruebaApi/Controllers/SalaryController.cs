﻿//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using PruebaApi.Models;
using Services.DTO.Response;
using Services.Interfaces;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [Route("api/Salary")]
    [ApiController]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SalaryController : Controller
    {

        private readonly ISalaryServicesDomain ISalaryServicesDomain;

        public SalaryController(ISalaryServicesDomain I_SalaryServicesDomain)
        {
            this.ISalaryServicesDomain = I_SalaryServicesDomain;
        }
 

        [HttpGet("GetAllSalariesOfEmployees")]
        public async Task<ActionResult<ResultDto>> GetAllSalariesOfEmployees()
        {
            return await ISalaryServicesDomain.GetAllSalariesOfEmployees();
        }
         
        [HttpPost("GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade")]
        public async Task<ActionResult<ResultDto>> GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade([FromBody] RequestSalaryDto data)
        {
            return await ISalaryServicesDomain.GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade(data.OfficeId, data.Grade);
        }

        [HttpPost("GetEmployeesWithEqualsGradeByGrade")]
        public async Task<ActionResult<ResultDto>> GetEmployeesWithEqualsGradeByGrade([FromBody] RequestSalaryDto data)
        {
            return await ISalaryServicesDomain.GetEmployeesWithEqualsGradeByGrade(data.Grade);
        }

        [HttpPost("GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade")]
        public async Task<ActionResult<ResultDto>> GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade([FromBody] RequestSalaryDto data)
        {
            return await ISalaryServicesDomain.GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(data.Position, data.Grade);
        }
         
    }
}
