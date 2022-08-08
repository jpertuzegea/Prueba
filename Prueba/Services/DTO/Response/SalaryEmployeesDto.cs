//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using System;

namespace Services.DTO.Response
{
    public class SalaryEmployeesDto
    {
        public int? Id { get; set; }       
        public string FullName { get; set; }
        public int Division { get; set; }
        public string DivisionName { get; set; }
        public int Position { get; set; }
        public string PositionName { get; set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; } 
        public decimal TotalSalary { get; set; }
         
    }
}
