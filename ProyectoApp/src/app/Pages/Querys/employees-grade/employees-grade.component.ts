import { Component, OnInit } from '@angular/core';
import { SalaryService } from '../../../Services/salary.service';
import { SalaryEmployeesModel } from '../../../Models/SalaryEmployeesModel';
import { ResultModel } from '../../../Models/ResultModel';

@Component({
  selector: 'app-employees-grade',
  templateUrl: './employees-grade.component.html',
  styleUrls: ['./employees-grade.component.css']
})
export class EmployeesGradeComponent implements OnInit {

  List: SalaryEmployeesModel[] = [];


  constructor(private SalaryServicex: SalaryService) { }

  ngOnInit(): void {
    this.ListSalaryEmployees();
  }

  ListSalaryEmployees() {

    this.SalaryServicex.GetAllSalariesOfEmployees().subscribe(

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
