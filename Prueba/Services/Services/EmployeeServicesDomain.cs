//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using DataAccess.Entitys;
using DataAccess.Interfaces;
using System.Linq;
using Microsoft.Extensions.Logging;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class EmployeeServicesDomain : IEmployeeServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly ILogger<EmployeeServicesDomain> logger;


        public EmployeeServicesDomain(IUnitOfWork _unitofwork, ILogger<EmployeeServicesDomain> logger)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
        }




        public async Task<ResultModel> GetAllEmployees()
        {
            ResultModel ResultModel = new ResultModel();

            try
            {
                ResultModel = null;

                var List = await unitofwork.GetRepository<EMPLOYEE>().Get();
                ResultModel.HasError = false;
                ResultModel.Messages = "Empleados Listados Con Exito";
                ResultModel.Data = List.ToArray();

                return ResultModel;
            }
            catch (Exception Error)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Error Técnico Buscando Empleados";
                ResultModel.Data = Error;

                return ResultModel;
            }
        }

        public async Task<ResultModel> GetEmployeeById(int id)
        {
            ResultModel ResultModel = new ResultModel();

            if (id <= 0)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Debe seleccionar un empleado";
                ResultModel.Data = string.Empty;

                return ResultModel;
            }

            try
            {
                ResultModel = null;

                var emplo = (await unitofwork.GetRepository<EMPLOYEE>().Get(x => x.EmployeeId == id)).FirstOrDefault();
               
                if (emplo != null)
                {
                    ResultModel.HasError = false;
                    ResultModel.Messages = "Empleado Encontrado";
                    ResultModel.Data = emplo;
                }
                else
                {
                    ResultModel.HasError = false;
                    ResultModel.Messages = "Empleado No Encontrado";
                    ResultModel.Data = emplo;
                }
                 
                return ResultModel;
            }
            catch (Exception Error)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Error Técnico Buscando Empleado";
                ResultModel.Data = Error;

                return ResultModel;
            }
        }


        public async Task<ResultModel> SaveEmployee(EmployeeDomainEntity employee)
        {
             
        }
    }
}
