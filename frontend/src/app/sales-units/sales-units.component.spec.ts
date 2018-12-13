import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesUnitsComponent } from './sales-units.component';

describe('SalesUnitsComponent', () => {
  let component: SalesUnitsComponent;
  let fixture: ComponentFixture<SalesUnitsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalesUnitsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesUnitsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
