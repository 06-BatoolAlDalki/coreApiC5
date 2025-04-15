import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UrlNewService {

  constructor(private _url : HttpClient) { }


  getAllStudnt(): Observable<any> {
    return this._url.get("https://localhost:7000/api/Student/getStudents");
  }

  getStudentById(id :any): Observable<any> {
    return this._url.get(`https://localhost:7000/api/Student/getStudentById/${id}`)
  }

  addStudent(data: any): Observable<any> {
    return this._url.post("https://localhost:7000/api/Student", data)
  }


  editStudent( id:any, data :any):  Observable<any> {
    return this._url.put(`https://localhost:7000/api/Student/editStudent/${id}`, data )
  }


  deleteStudent(id: any) {
    return this._url.delete(`https://localhost:7000/api/Student/deleteStudent?id=${id}`)
  }
}
