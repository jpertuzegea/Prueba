//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------

using System;

namespace Entities
{
    public class EmployeeDomainEntity
    {
        public int? EmployeeId { get; private set; }
        public string EmployeeCode { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeSurname { get; private set; }
        public string IdentificationNumber { get; private set; }
        public DateTime Birthday { get; private set; }
        public int Age { get; private set; }

        internal EmployeeDomainEntity()
        {
        }



        public EmployeeDomainEntity(int employeeId, string employeeCode, string employeeName, string employeeSurname, string identificationNumber, DateTime birthday)
        {
            EmployeeId = employeeId;
            EmployeeCode = employeeCode;
            EmployeeName = employeeName;
            EmployeeSurname = employeeSurname;
            IdentificationNumber = identificationNumber;
            Birthday = birthday;

            Age = (DateTime.Now.Year - birthday.Year);
        }


       


    }
}
