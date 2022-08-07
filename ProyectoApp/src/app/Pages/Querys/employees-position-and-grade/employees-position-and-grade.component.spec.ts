import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeesPositionAndGradeComponent } from './employees-position-and-grade.component';

describe('EmployeesPositionAndGradeComponent', () => {
  let component: EmployeesPositionAndGradeComponent;
  let fixture: ComponentFixture<EmployeesPositionAndGradeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeesPositionAndGradeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeesPositionAndGradeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
