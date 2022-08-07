using DataAccess.Entitys;
using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class SalaryServicesDomain : ISalaryServicesDomain
    {

        private readonly IUnitOfWork unitofwork;
        private readonly ILogger<SalaryServicesDomain> logger;

        public SalaryServicesDomain(IUnitOfWork _unitofwork, ILogger<SalaryServicesDomain> logger)
        {
            this.unitofwork = _unitofwork;
            this.logger = logger;
        }


        // - Mostrar en una tabla los salarios de todos los empleados
        public async Task<ResultDto> GetAllSalariesOfEmployees()
        {
            ResultDto ResultModel = new ResultDto();

            try
            {
                var List = (await unitofwork.GetRepository<SALARY>().Get()).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var xx = List.Select(item =>
                      {
                       //   armar el dto solo con los datos del empleado y su salario mes a mes ,
                          return item;
                      });

                    ResultModel.Data = xx;
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
        public async Task<ResultDto> GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade(int OfficeId, int Grade)
        {
            ResultDto ResultModel = new ResultDto();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade && x.Office == OfficeId)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var xx = List.Select(item =>
                    {
                       // armar el dto solo con los datos del empleado y su salario mes a mes ,
                          return item;
                    });

                    ResultModel.Data = xx;
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



        // - Empleados de todas las Oficinas y con el mismo Grado.
        // distin oficinas 
        public async Task<ResultDto> GetEmployeesWithEqualsGradeByGrade(int Grade)
        {
            ResultDto ResultModel = new ResultDto();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var xx = List.Select(item =>
                    {
                        //armar el dto solo con los datos del empleado y su salario mes a mes ,
                          return item;
                    });

                    ResultModel.Data = xx;
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




        // - Empleados con la misma Posición y Grado.
        public async Task<ResultDto> GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(int Position, int Grade)
        {
            ResultDto ResultModel = new ResultDto();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Position == Position && x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var xx = List.Select(item =>
                    {
                       // armar el dto solo con los datos del empleado y su salario mes a mes ,
                          return item;
                    });

                    ResultModel.Data = xx;
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



        // - Empleados de todas las Posiciones y con el mismo Grado.
        // distin posiciones 
        public async Task<ResultDto> GetEmployeesWithEqualsGradeByGradexxx( int Grade)
        {
            ResultDto ResultModel = new ResultDto();

            try
            {
                // hacer el disting de empleados 
                var List = (await unitofwork.GetRepository<SALARY>().Get(x => x.Grade == Grade)).OrderBy(x => x.EmployeeCode);

                if (List.Any())
                {
                    var xx = List.Select(item =>
                    {
                     //   armar el dto solo con los datos del empleado y su salario mes a mes ,
                          return item;
                    });

                    ResultModel.Data = xx;
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
    }

}
