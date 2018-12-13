import { TestBed, inject } from '@angular/core/testing';

import { SalesUnitDetailsService } from './sales-unit-details.service';

describe('SalesUnitDetailsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalesUnitDetailsService]
    });
  });

  it('should be created', inject([SalesUnitDetailsService], (service: SalesUnitDetailsService) => {
    expect(service).toBeTruthy();
  }));
});
