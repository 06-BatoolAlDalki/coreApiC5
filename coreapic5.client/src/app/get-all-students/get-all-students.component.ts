import { Component } from '@angular/core';
import { UrlNewService } from '../newService/url-new.service';

@Component({
  selector: 'app-get-all-students',
  templateUrl: './get-all-students.component.html',
  styleUrl: './get-all-students.component.css'
})
export class GetAllStudentsComponent {


  constructor(private _ser : UrlNewService) { }

  ngOnInit() {

    this.getAllStudents()
  }

  container :any
  getAllStudents() {
    this._ser.getAllStudnt().subscribe((data) => {
      this.container = data
    })
  }

  deleteStudent(id :any) {

    this._ser.deleteStudent(id).subscribe(() => {

      alert("delete successfully !!!")
      this.getAllStudents()
    })
  }
}
