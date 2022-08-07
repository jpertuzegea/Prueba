import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'; 
import { AllEmployeesSalaryComponent } from './all-employees-salary/all-employees-salary.component';
import { EmployeesAverageSalaryComponent } from './employees-average-salary/employees-average-salary.component';
import { EmployeesGradeComponent } from './employees-grade/employees-grade.component';
import { EmployeesOficceAndGradeComponent } from './employees-oficce-and-grade/employees-oficce-and-grade.component';
import { EmployeesPositionAndGradeComponent } from './employees-position-and-grade/employees-position-and-grade.component';
import { MainQuerysComponent } from './main-querys.component';


const routes: Routes = [

  {
    path: 'Queries', component: MainQuerysComponent,

    children: [
      { path: 'AllEmployeesSalary', component: AllEmployeesSalaryComponent },
      { path: 'EmployeesOficceAndGrade', component: EmployeesOficceAndGradeComponent },
      { path: 'EmployeesGrade', component: EmployeesGradeComponent },
      { path: 'EmployeesPositionAndGrade', component: EmployeesPositionAndGradeComponent },
      { path: 'EmployeesAverageSalary', component: EmployeesAverageSalaryComponent },
       
    ]
  }

];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class QuerysRoutingModule { }
