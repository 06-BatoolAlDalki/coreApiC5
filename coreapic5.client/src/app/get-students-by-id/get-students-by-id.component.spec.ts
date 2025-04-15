import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetStudentsByIdComponent } from './get-students-by-id.component';

describe('GetStudentsByIdComponent', () => {
  let component: GetStudentsByIdComponent;
  let fixture: ComponentFixture<GetStudentsByIdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [GetStudentsByIdComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GetStudentsByIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
