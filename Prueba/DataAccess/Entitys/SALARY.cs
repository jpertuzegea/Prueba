using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entitys
{
    public class SALARY
    {
        [Key]
        public int? Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Office { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }

        public string IdentificationNumber { get; set; }
        public DateTime Birthday { get; set; }


        public int Division { get; set; }
        public int Position { get; set; }
        public int Grade { get; set; }

        public DateTime BeginDate { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal ProductionBonus { get; set; }
        public decimal CompensationBonus { get; set; }
        public decimal Commission { get; set; }
        public decimal Contributions { get; set; }
        public decimal TotalSalary { get; set; }


    }
}
