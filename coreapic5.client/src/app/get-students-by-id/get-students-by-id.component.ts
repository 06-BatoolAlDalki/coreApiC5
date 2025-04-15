import { Component } from '@angular/core';
import { UrlNewService } from '../newService/url-new.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-get-students-by-id',
  templateUrl: './get-students-by-id.component.html',
  styleUrl: './get-students-by-id.component.css'
})
export class GetStudentsByIdComponent {


  constructor(private _ser : UrlNewService , private _active : ActivatedRoute) { }

  ngOnInit() {
    this.getStudentById()
  }

  container :any
  getStudentById() {
    let id = this._active.snapshot.paramMap.get('id');
    this._ser.getStudentById(id).subscribe((data) => {

      this.container = data
    })
  }
}
