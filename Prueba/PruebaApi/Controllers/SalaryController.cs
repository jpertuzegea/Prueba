//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
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


        // GetAllSalariesOfEmployees();

        // GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade(int OfficeId, int Grade);

        // GetEmployeesWithEqualsGradeByGrade(int Grade);

        // GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(int Position, int Grade);

        // GetEmployeesWithEqualsGradeByGradexxx(int Grade);



        [HttpGet("GetAllSalariesOfEmployees")]
        public async Task<ActionResult<ResultDto>> GetAllSalariesOfEmployees()
        {
            return await ISalaryServicesDomain.GetAllSalariesOfEmployees();
        }



        //[HttpPost("UserAdd")]
        //public async Task<ActionResult<ResultModel>> UserAdd([FromBody] Users UserModel)
        //{
        //    return await I_Bll_Users.UserAdd(UserModel);
        //}



        //[HttpPost("GetUserByUserId")]
        //public async Task<ActionResult<ResultModel>> GetUserByUserId([FromBody] int UserId)
        //{
        //    return await I_Bll_Users.GetUserByUserId(UserId);
        //}

        //[HttpPut("UserUpdt")]
        //public async Task<ActionResult<ResultModel>> UserUpdt([FromBody] Users UserModel)
        //{
        //    return await I_Bll_Users.UserUpdate(UserModel);
        //}







    }
}
