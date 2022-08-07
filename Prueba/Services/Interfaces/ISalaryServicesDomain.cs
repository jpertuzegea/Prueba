using Services.DTO;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ISalaryServicesDomain
    {
        Task<ResultDto> GetAllSalariesOfEmployees();

        Task<ResultDto> GetEmployeesWithEqualsOfficeAndGradeByOfficeIdAndGrade(int OfficeId, int Grade);

        Task<ResultDto> GetEmployeesWithEqualsGradeByGrade(int Grade);

        Task<ResultDto> GetEmployeesWithEqualsPositionAndGradeByPositionAndGrade(int Position, int Grade);
         
        Task<ResultDto> GetEmployeesWithEqualsGradeByGradexxx(int Grade);

    }
}
