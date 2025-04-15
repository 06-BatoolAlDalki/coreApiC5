import { Component, DoCheck } from '@angular/core';
import { UrlNewService } from '../newService/url-new.service';
import { from } from 'rxjs';

@Component({
  selector: 'app-add-students',
  templateUrl: './add-students.component.html',
  styleUrl: './add-students.component.css'
})
export class AddStudentsComponent implements DoCheck {

  ngDoCheck() { }
  constructor(private _ser : UrlNewService) { }
  
  ngOnInit() { }

  addStudent(data: any) {
   
    var form = new FormData();
    form.append("Name", data.Name)
    form.append("Email", data.Email)

    this._ser.addStudent(form).subscribe(() => {
      alert("added!!!!")
    })
  }
}
