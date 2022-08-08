import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { RequestSalary } from '../Models/RequestSalary';

@Injectable({
  providedIn: 'root'
})

export class SalaryService {

  constructor(private http: HttpClient) { }

  public GetAllSalariesOfEmployees() {
    return this.http.get(environment.BaseUrl + "api/Salary/GetAllSalariesOfEmployees");
  }


  public GetAllSalariesOfEmployeesQuery(RequestSalary: RequestSalary) {
    return this.http.post(environment.BaseUrl + "api/Salary/GetAllSalariesOfEmployees", RequestSalary);
  }

}
