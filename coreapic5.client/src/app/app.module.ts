import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudetnComponent } from './studetn/studetn.component';
import { GetAllStudentsComponent } from './get-all-students/get-all-students.component';
import { GetStudentsByIdComponent } from './get-students-by-id/get-students-by-id.component';
import { AddStudentsComponent } from './add-students/add-students.component';
import { EditStudentByIdComponent } from './edit-student-by-id/edit-student-by-id.component';

@NgModule({
  declarations: [
    AppComponent,
    StudetnComponent,
    GetAllStudentsComponent,
    GetStudentsByIdComponent,
    AddStudentsComponent,
    EditStudentByIdComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
