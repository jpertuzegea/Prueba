//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace Services.DTO.Response
{
    public class SalaryEmployeesDto
    {
        public int? Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string IdentificationNumber { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
