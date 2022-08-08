//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Services.DTO.Response;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISalaryServicesDomain
    {
        Task<ResultDto> GetAllSalariesOfEmployees();

        Task<ResultDto> GetAllSalariesOfEmployees(int OfficeId, int Grade, int Position);




        Task<ResultDto> GetEmployeesWithEqualsGradeByGrade(int Grade);

        Task<ResultDto> GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(int Position, int Grade);
         
        Task<ResultDto> GetEmployeesWithEqualsGradeByGradexxx(int Grade);

    }
}
