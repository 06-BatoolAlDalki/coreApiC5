import { Component } from '@angular/core';
import { UrlService } from '../Service/url.service';

@Component({
  selector: 'app-studetn',
  templateUrl: './studetn.component.html',
  styleUrl: './studetn.component.css'
})
export class StudetnComponent {

  ngOnInit() {
    this.getData()
  }

  constructor(private _ser : UrlService) {

  }
  container :any
  getData() {
    this._ser.getStudents().subscribe((data) => {
      this.container = data
    })

  }
}
