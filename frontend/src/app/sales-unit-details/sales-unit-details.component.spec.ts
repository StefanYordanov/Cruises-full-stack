import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesUnitDetailsComponent } from './sales-unit-details.component';

describe('SalesUnitDetailsComponent', () => {
  let component: SalesUnitDetailsComponent;
  let fixture: ComponentFixture<SalesUnitDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalesUnitDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesUnitDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
