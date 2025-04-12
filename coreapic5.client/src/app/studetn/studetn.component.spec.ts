import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudetnComponent } from './studetn.component';

describe('StudetnComponent', () => {
  let component: StudetnComponent;
  let fixture: ComponentFixture<StudetnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StudetnComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudetnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
