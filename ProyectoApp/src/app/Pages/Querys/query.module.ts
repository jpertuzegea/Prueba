import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '../Shared/shared.module';
import { MainQuerysComponent } from './main-querys.component';
import { AllEmployeesSalaryComponent } from './all-employees-salary/all-employees-salary.component';
import { EmployeesOficceAndGradeComponent } from './employees-oficce-and-grade/employees-oficce-and-grade.component';
import { EmployeesGradeComponent } from './employees-grade/employees-grade.component';
import { EmployeesPositionAndGradeComponent } from './employees-position-and-grade/employees-position-and-grade.component';
import { EmployeesAverageSalaryComponent } from './employees-average-salary/employees-average-salary.component';



@NgModule({
  declarations: [
    MainQuerysComponent,
    AllEmployeesSalaryComponent,
    EmployeesOficceAndGradeComponent,
    EmployeesGradeComponent,
    EmployeesPositionAndGradeComponent,
    EmployeesAverageSalaryComponent,
  ],

  imports: [
    RouterModule,
    BrowserModule, 
    SharedModule,
  ],

  exports: [
    AllEmployeesSalaryComponent,
    EmployeesOficceAndGradeComponent,
    EmployeesGradeComponent,
    EmployeesPositionAndGradeComponent,
    EmployeesAverageSalaryComponent,
  ],
})
export class QueryModule { }
