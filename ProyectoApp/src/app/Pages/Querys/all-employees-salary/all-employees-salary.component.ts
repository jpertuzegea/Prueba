import { Component, OnInit } from '@angular/core';
import { SalaryEmployeesModel } from '../../../Models/SalaryEmployeesModel';
import { ResultModel } from '../../../Models/ResultModel'; 
import { SalaryService } from '../../../Services/salary.service';

@Component({
  selector: 'app-all-employees-salary',
  templateUrl: './all-employees-salary.component.html',
  styleUrls: ['./all-employees-salary.component.css']
})
export class AllEmployeesSalaryComponent implements OnInit {

  constructor(private SalaryService: SalaryService) { }

  List: SalaryEmployeesModel[] = [];
   
  ngOnInit(): void {
    this.ListSalaryEmployees();
  }
   
  ListSalaryEmployees() {

    this.SalaryService.GetAllSalariesOfEmployees().subscribe(

      ResultModel => {
         
        let Resu = ResultModel as ResultModel;
         
        if (!Resu.HasError) {

          let Array = Resu.Data as SalaryEmployeesModel[];
           
          if (Resu.Data) {

            this.List = Array;

          } else {
            console.log('sin datos para mostrar')
          }

        } else {
          alert(Resu.Messages);
        }

      }, error => {

        if (error.status == 401) {
          alert("No Autorizado");
        } else {
          alert(JSON.stringify(error));
        } 
      }
    );

  }



}
