//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using Entities;
using Services.DTO;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeServicesDomain
    {
        Task<ResultModel> GetAllEmployees();
        Task<ResultModel> GetEmployeeById(int id);
        Task<ResultModel> SaveEmployee(EmployeeDomainEntity employeeDto);
    }


}
