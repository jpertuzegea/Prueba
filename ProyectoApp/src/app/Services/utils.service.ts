import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UtilsService {

  constructor(private http: HttpClient) { }

  public SelectPosition() {
    return this.http.get(environment.BaseUrl + "api/Utils/SelectPosition");
  }

  public SelectGrade() {
    return this.http.get(environment.BaseUrl + "api/Utils/SelectGrade");
  }

  public SelectOfices() {
    return this.http.get(environment.BaseUrl + "api/Utils/SelectOfices");
  }



}
