import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeesAverageSalaryComponent } from './employees-average-salary.component';

describe('EmployeesAverageSalaryComponent', () => {
  let component: EmployeesAverageSalaryComponent;
  let fixture: ComponentFixture<EmployeesAverageSalaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeesAverageSalaryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeesAverageSalaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
