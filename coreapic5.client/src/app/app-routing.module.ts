import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GetAllStudentsComponent } from './get-all-students/get-all-students.component';
import { GetStudentsByIdComponent } from './get-students-by-id/get-students-by-id.component';
import { AddStudentsComponent } from './add-students/add-students.component';
import { EditStudentByIdComponent } from './edit-student-by-id/edit-student-by-id.component';

const routes: Routes = [

  { path: "students", component: GetAllStudentsComponent },
  { path: "getStudentById/:id", component: GetStudentsByIdComponent },
  { path: "addStudent", component: AddStudentsComponent },
  { path: "editStudent/:id", component: EditStudentByIdComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
