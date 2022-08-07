//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

namespace Services.DTO.Response
{
    public class EmployeesEqualsGradeDto
    {
        public int? Id { get; set; }
        public int Office { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string IdentificationNumber { get; set; }
        public int Grade { get; set; }


    }
}
