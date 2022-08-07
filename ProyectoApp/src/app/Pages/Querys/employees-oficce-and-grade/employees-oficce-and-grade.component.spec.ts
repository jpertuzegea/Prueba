import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeesOficceAndGradeComponent } from './employees-oficce-and-grade.component';

describe('EmployeesOficceAndGradeComponent', () => {
  let component: EmployeesOficceAndGradeComponent;
  let fixture: ComponentFixture<EmployeesOficceAndGradeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeesOficceAndGradeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeesOficceAndGradeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
