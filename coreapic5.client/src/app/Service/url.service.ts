import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UrlService {

  constructor(private _http : HttpClient) { }

  getStudents() :Observable<any> {

    return this._http.get("https://localhost:7000/api/Student/getStudents")
  }


  
}
