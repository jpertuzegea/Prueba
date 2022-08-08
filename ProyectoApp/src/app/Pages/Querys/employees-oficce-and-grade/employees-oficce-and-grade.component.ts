import { Component, OnInit } from '@angular/core';
import { SalaryService } from '../../../Services/salary.service';
import { SalaryEmployeesModel } from '../../../Models/SalaryEmployeesModel';
import { ResultModel } from '../../../Models/ResultModel';
import { SelectModel } from '../../../Models/SelectModel';
import { UtilsService } from '../../../Services/utils.service';

@Component({
  selector: 'app-employees-oficce-and-grade',
  templateUrl: './employees-oficce-and-grade.component.html',
  styleUrls: ['./employees-oficce-and-grade.component.css']
})
export class EmployeesOficceAndGradeComponent implements OnInit {

  constructor(private SalaryService: SalaryService, private UtilsService: UtilsService) { }

  ListGrade: SelectModel[];
  ListPosition: SelectModel[];
  ListOfice: SelectModel[];

  List: SalaryEmployeesModel[] = [];

  ngOnInit(): void {

    //this.ListSalaryEmployees();
    this.ListPositions();
    this.ListGrades();
    this.ListOfices();
   
  }



  ListSalaryEmployees() {

    const obj = {
      OfficeId: 1,
      Grade: 2,
      Position: 3,
    }
    this.SalaryService.GetAllSalariesOfEmployeesQuery(obj).subscribe(

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


  ListPositions() {
    this.UtilsService.SelectPosition().subscribe(
      ResultModel => {
        let Resu = ResultModel as ResultModel;
        if (!Resu.HasError) {
          console.log(Resu.Data);
          this.ListPosition = Resu.Data as SelectModel[];
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

  ListGrades() {
    this.UtilsService.SelectGrade().subscribe(
      ResultModel => {
        let Resu = ResultModel as ResultModel;
        if (!Resu.HasError) {
          console.log(Resu.Data);
          this.ListGrade = Resu.Data as SelectModel[];
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

  ListOfices() {
    this.UtilsService.SelectOfices().subscribe(
      ResultModel => {
        let Resu = ResultModel as ResultModel;
        if (!Resu.HasError) {
          console.log(Resu.Data);
          this.ListOfice = Resu.Data as SelectModel[];
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
