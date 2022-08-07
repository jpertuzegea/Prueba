using System;

namespace Entities
{
    public class SalaryDomainEntity
    {
        internal SalaryDomainEntity()
        {

        }


        public int? Id { get; private set; }
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Office { get; private set; }
        public string EmployeeCode { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeSurname { get; private set; }
        public string IdentificationNumber { get; private set; }
        public DateTime Birthday { get; private set; }
        public int Division { get; private set; }
        public int Position { get; private set; }
        public int Grade { get; private set; }
        public DateTime BeginDate { get; private set; }
        public decimal BaseSalary { get; private set; }
        public decimal ProductionBonus { get; private set; }
        public decimal CompensationBonus { get; private set; }
        public decimal Commission { get; private set; }
        public decimal Contributions { get; private set; }
        public decimal TotalSalary { get; private set; }



        //public SalaryDomainEntity(int employeeId, string nameEmployee, Office office, Division division, int hourtotal, double valuehour .. )
        //{
        //    EmployeeId = employeeId;
        //    NameEmployee = nameEmployee;
        //    Office = office;
        //    CalculateIncome(hourtotal, valuehour);
        //}



        // private void CalculateIncome(int hourtotal, double hourValue)
        //{
        //    Income = hourtotal * hourValue;
        //}

        //private void CalcuteCommision(int hourtotal, double valuehour, double percentageCommision, Office office, Employee employee)
        //{
        //    if (office.Id == 1 && employee.localidad == "USME")
        //        commision = (hourtotal * valuehour * percentageCommision) + 0,20;

        //}
    }
}
