import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditStudentByIdComponent } from './edit-student-by-id.component';

describe('EditStudentByIdComponent', () => {
  let component: EditStudentByIdComponent;
  let fixture: ComponentFixture<EditStudentByIdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditStudentByIdComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditStudentByIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
