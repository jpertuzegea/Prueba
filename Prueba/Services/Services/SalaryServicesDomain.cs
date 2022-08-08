//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using DataAccess.Entitys;
using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Services.DTO.Response;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SalaryServicesDomain : ISalaryServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly IDivisionServicesDomain IDivisionServicesDomain;
        private readonly IPositionServicesDomain IPositionServicesDomain;


        private readonly ILogger<SalaryServicesDomain> logger;


        public SalaryServicesDomain(IUnitOfWork _unitofwork, ILogger<SalaryServicesDomain> logger, IDivisionServicesDomain I_DivisionServicesDomain, IPositionServicesDomain I_PositionServicesDomain)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
            this.IDivisionServicesDomain = I_DivisionServicesDomain;
            this.IPositionServicesDomain = I_PositionServicesDomain;

        }


        // - Mostrar en una tabla los salarios de todos los empleados
        public async Task<ResultDto> GetAllSalariesOfEmployees()
        {
            ResultDto ResultModel = new ResultDto();

            List<SalaryEmployeesDto> ListSalaryEmployeesDto = new List<SalaryEmployeesDto>();

            try
            {
                var List = (await unitofwork.GetRepository<SALARY>().Get()).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    foreach (var item in List)
                    {
                        SalaryEmployeesDto SalaryEmployeesDto = new SalaryEmployeesDto();

                        SalaryEmployeesDto.Id = item.Id;
                        SalaryEmployeesDto.FullName = item.EmployeeName + " " + item.EmployeeSurname;
                        SalaryEmployeesDto.Division = item.Division;
                        SalaryEmployeesDto.DivisionName = (await IDivisionServicesDomain.GetDivisionByDivisionId(item.Division)).Name;

                        SalaryEmployeesDto.Position = item.Position;
                        SalaryEmployeesDto.PositionName = (await IPositionServicesDomain.GetPositionByPositionId(item.Position)).Name;

                        SalaryEmployeesDto.Grade = item.Grade;
                        SalaryEmployeesDto.BeginDate = item.BeginDate;
                        SalaryEmployeesDto.Birthday = item.Birthday;
                        SalaryEmployeesDto.IdentificationNumber = item.IdentificationNumber;
                        SalaryEmployeesDto.TotalSalary = item.TotalSalary;

                        ListSalaryEmployeesDto.Add(SalaryEmployeesDto);
                    }

                    ResultModel.Data = ListSalaryEmployeesDto;
                }

                ResultModel.HasError = false;
                ResultModel.Messages = "Salarios Listados Con Exito";

                return ResultModel;
            }
            catch (Exception Error)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Error Técnico Buscando Salarios";
                ResultModel.Data = Error;

                return ResultModel;
            }
        }

        // - Empleados con la misma Oficina y Grado.
        public async Task<ResultDto> GetAllSalariesOfEmployees(int OfficeId, int Grade, int Position)
        {
            ResultDto ResultModel = new ResultDto();
            List<SalaryEmployeesDto> ListSalaryEmployeesDto = new List<SalaryEmployeesDto>();

            try
            {
                var List = (await unitofwork.GetRepository<SALARY>().Get()).OrderBy(x => x.EmployeeCode);
                // var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade && x.Office == OfficeId)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    foreach (var item in List)
                    {
                        SalaryEmployeesDto SalaryEmployeesDto = new SalaryEmployeesDto();

                        SalaryEmployeesDto.Id = item.Id;
                        SalaryEmployeesDto.FullName = item.EmployeeName + " " + item.EmployeeSurname;
                        SalaryEmployeesDto.Division = item.Division;
                        SalaryEmployeesDto.DivisionName = (await IDivisionServicesDomain.GetDivisionByDivisionId(item.Division)).Name;

                        SalaryEmployeesDto.Position = item.Position;
                        SalaryEmployeesDto.PositionName = (await IPositionServicesDomain.GetPositionByPositionId(item.Position)).Name;

                        SalaryEmployeesDto.Grade = item.Grade;
                        SalaryEmployeesDto.BeginDate = item.BeginDate;
                        SalaryEmployeesDto.Birthday = item.Birthday;
                        SalaryEmployeesDto.IdentificationNumber = item.IdentificationNumber;
                        SalaryEmployeesDto.TotalSalary = item.TotalSalary;

                        ListSalaryEmployeesDto.Add(SalaryEmployeesDto);
                    }

                    ResultModel.Data = ListSalaryEmployeesDto;
                }

                ResultModel.HasError = false;
                ResultModel.Messages = "Empleados  Listados Con Exito";


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







        // - Empleados de todas las Oficinas y con el mismo Grado.
        // distin oficinas 
        public async Task<ResultDto> GetEmployeesWithEqualsGradeByGrade(int Grade)
        {
            ResultDto ResultModel = new ResultDto();
            List<EmployeesEqualsGradeDto> ListEmployeesEqualsGradeDto = new List<EmployeesEqualsGradeDto>();


            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var obj = List.Select(item =>
                    {
                        EmployeesEqualsGradeDto EmployeesEqualsGradeDto = new EmployeesEqualsGradeDto();

                        EmployeesEqualsGradeDto.Id = item.Id;
                        EmployeesEqualsGradeDto.Office = item.Office;
                        EmployeesEqualsGradeDto.EmployeeCode = item.EmployeeCode;
                        EmployeesEqualsGradeDto.EmployeeName = item.EmployeeName;
                        EmployeesEqualsGradeDto.EmployeeSurname = item.EmployeeName;
                        EmployeesEqualsGradeDto.IdentificationNumber = item.IdentificationNumber;
                        EmployeesEqualsGradeDto.Grade = item.Grade;

                        ListEmployeesEqualsGradeDto.Add(EmployeesEqualsGradeDto);

                        return item;
                    });

                    ResultModel.Data = ListEmployeesEqualsGradeDto;
                }

                ResultModel.HasError = false;
                ResultModel.Messages = "Empleados Listados Con Exito";


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

        // - Empleados con la misma Posición y Grado.
        public async Task<ResultDto> GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(int Position, int Grade)
        {
            ResultDto ResultModel = new ResultDto();
            List<EmployeesEqualsOfficeAndGradeDto> ListEmployeesEqualsOfficeAndGradeDto = new List<EmployeesEqualsOfficeAndGradeDto>();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Position == Position && x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var obj = List.Select(item =>
                    {
                        EmployeesEqualsOfficeAndGradeDto EmployeesEqualsOfficeAndGradeDto = new EmployeesEqualsOfficeAndGradeDto();

                        EmployeesEqualsOfficeAndGradeDto.Id = item.Id;
                        EmployeesEqualsOfficeAndGradeDto.Office = item.Office;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeCode = item.EmployeeCode;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeName = item.EmployeeName;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeSurname = item.EmployeeName;
                        EmployeesEqualsOfficeAndGradeDto.IdentificationNumber = item.IdentificationNumber;
                        EmployeesEqualsOfficeAndGradeDto.Grade = item.Grade;
                        EmployeesEqualsOfficeAndGradeDto.Position = item.Position;

                        ListEmployeesEqualsOfficeAndGradeDto.Add(EmployeesEqualsOfficeAndGradeDto);

                        return item;
                    });

                    ResultModel.Data = ListEmployeesEqualsOfficeAndGradeDto;
                }

                ResultModel.HasError = false;
                ResultModel.Messages = "Empleados Listados Con Exito";


                return ResultModel;
            }
            catch (Exception Error)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Error Técnico Buscando Empleados ";
                ResultModel.Data = Error;

                return ResultModel;
            }
        }

        // - Empleados de todas las Posiciones y con el mismo Grado.
        // distin posiciones 
        public async Task<ResultDto> GetEmployeesWithEqualsGradeByGradexxx(int Grade)
        {
            ResultDto ResultModel = new ResultDto();
            List<EmployeesEqualsOfficeAndGradeDto> ListEmployeesEqualsOfficeAndGradeDto = new List<EmployeesEqualsOfficeAndGradeDto>();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var obj = List.Select(item =>
                    {
                        EmployeesEqualsOfficeAndGradeDto EmployeesEqualsOfficeAndGradeDto = new EmployeesEqualsOfficeAndGradeDto();

                        EmployeesEqualsOfficeAndGradeDto.Id = item.Id;
                        EmployeesEqualsOfficeAndGradeDto.Office = item.Office;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeCode = item.EmployeeCode;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeName = item.EmployeeName;
                        EmployeesEqualsOfficeAndGradeDto.EmployeeSurname = item.EmployeeName;
                        EmployeesEqualsOfficeAndGradeDto.IdentificationNumber = item.IdentificationNumber;
                        EmployeesEqualsOfficeAndGradeDto.Grade = item.Grade;
                        EmployeesEqualsOfficeAndGradeDto.Position = item.Position;

                        ListEmployeesEqualsOfficeAndGradeDto.Add(EmployeesEqualsOfficeAndGradeDto);

                        return item;
                    });

                    ResultModel.Data = ListEmployeesEqualsOfficeAndGradeDto;
                }

                ResultModel.HasError = false;
                ResultModel.Messages = "Empleados Listados Con Exito";


                return ResultModel;
            }
            catch (Exception Error)
            {
                ResultModel.HasError = true;
                ResultModel.Messages = "Error Técnico Buscando Empleados ";
                ResultModel.Data = Error;

                return ResultModel;
            }
        }
    }

}
