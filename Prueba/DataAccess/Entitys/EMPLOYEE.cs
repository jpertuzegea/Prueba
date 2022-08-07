//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------


using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entitys
{
    public class EMPLOYEE
    {
        [Key]
        public int? EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }       
        public string IdentificationNumber { get; set; }
        public DateTime Birthday { get; set; }
         
    }

}
