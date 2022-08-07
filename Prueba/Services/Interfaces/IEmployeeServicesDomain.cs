//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Entities;
using Services.DTO.Response;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeServicesDomain
    {
        Task<ResultDto> GetAllEmployees();
        Task<ResultDto> GetEmployeeById(int id);
        Task<ResultDto> SaveEmployee(EmployeeDomainEntity employeeDto);
    }


}
