import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllEmployeesSalaryComponent } from './all-employees-salary.component';

describe('AllEmployeesSalaryComponent', () => {
  let component: AllEmployeesSalaryComponent;
  let fixture: ComponentFixture<AllEmployeesSalaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllEmployeesSalaryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllEmployeesSalaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
