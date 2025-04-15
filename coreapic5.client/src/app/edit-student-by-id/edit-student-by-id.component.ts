import { Component } from '@angular/core';
import { UrlNewService } from '../newService/url-new.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-student-by-id',
  templateUrl: './edit-student-by-id.component.html',
  styleUrl: './edit-student-by-id.component.css'
})
export class EditStudentByIdComponent {

  constructor(private _ser : UrlNewService , private _active : ActivatedRoute) { }

  ngOnInit() { }

  editStudent(data :any) {
    let id = this._active.snapshot.paramMap.get('id');


    var form = new FormData();
    form.append("Name", data.Name)
    form.append("Email", data.Email)

    this._ser.editStudent(id, form).subscribe(() => {
      alert("edit successfully !!!!!")
    })
  }
}
